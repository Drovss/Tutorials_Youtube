using System.Collections.Generic;
using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.PoolQueue
{
    public class MonoPoolQueue<T> where T : MonoBehaviour
    {
        private const int DEFAULT_SIZE = 1;
        private const int DEFAULT_STEP = 1;
        
        private Queue<T> _pool;

        private readonly T _prefab;

        private readonly Transform _container;

        private readonly int _startSize;
        
        private readonly int _expansionStep;

        public int CountInactive => _pool.Count;

        public MonoPoolQueue(
            T prefab, 
            Transform container = null, 
            int startSize = DEFAULT_SIZE, 
            int expansionStep = DEFAULT_STEP)
        {
            _prefab = prefab;
            _container = container;
            _startSize = startSize;
            _expansionStep = expansionStep;

            CreatePool();
        }

        private void CreatePool()
        {
            _pool = new Queue<T>();

            ExpandPool(_startSize);
        }

        private void ExpandPool(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CreateElement();
            }
        }

        private T CreateElement(bool isActiveByDefault = false)
        {
            var element = UnityEngine.Object.Instantiate(_prefab, _container);
            element.gameObject.SetActive(isActiveByDefault);
            
            _pool.Enqueue(element);
            
            return element;
        }

        public T Get(bool isActive = false)
        {
            if (_pool.Count > 0)
            {
                return GetElement(isActive);
            }
            else
            {
                ExpandPool(_expansionStep);
                return GetElement(isActive);
            }
        }

        private T GetElement(bool isActive)
        {
            var element = _pool.Dequeue();
            element.gameObject.SetActive(isActive);
            return element;
        }

        public void Release(T element)
        {
            element.gameObject.SetActive(false);
            _pool.Enqueue(element);
        }

        public void Clear()
        {
            _pool.Clear();
        }
    }
}