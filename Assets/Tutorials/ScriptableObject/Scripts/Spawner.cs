using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

namespace Tutorials.ScriptableObject.Scripts
{
    public class Spawner: MonoBehaviour
    {
        [SerializeField] private ElementData _elementData;
        [SerializeField] private Coin _prefabCoin;
        [SerializeField] private Transform _container;

        [Space] 
        [SerializeField] private float _timeToSpawn;
        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private float _horizontalScatter;
        
        private IObjectPool<Coin> _pool;

        private float _time;

        private void Awake()
        {
            _pool = new ObjectPool<Coin>(
                CreateElement,
                OnGet,
                OnRelease);
        }

        private Coin CreateElement()
        {
            var element = Instantiate(_prefabCoin, _container);
            element.Pool = _pool;

            return element;
        }
        
        private void OnGet(Coin coin)
        {
            var element = GetRandomSettingsCoin();
            
            coin.transform.position = GeneratePosition();
            coin.DestroyPositionY = element.DestroyPositionY;
            coin.SetSprite(element.Sprite);
            coin.gameObject.SetActive(true);
        }

        private void OnRelease(Coin coin)
        {
            coin.gameObject.SetActive(false);
        }

        private Vector3 GeneratePosition()
        {
            var position = _pointSpawn.position;
            
            var x = Random.Range(
                position.x - _horizontalScatter,
                position.x + _horizontalScatter);

            var newPosition = new Vector3(x, position.y, position.z);

            return newPosition;
        }

        private Element GetRandomSettingsCoin()
        {
            var index = Random.Range(0, _elementData.Elements.Count);

            return _elementData.Elements[index];
        }

        private void Update()
        {
            if (_time < 0)
            {
                SpawnElement();
                
                _time = _timeToSpawn;
            }
            else
            {
                _time -= Time.deltaTime;
            }
        }

        private void SpawnElement()
        {
            _pool.Get();
        }

        private void OnDestroy()
        {
            _pool.Clear();
        }
    }
}