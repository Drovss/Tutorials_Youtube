using UnityEngine;
using UnityEngine.Pool;

namespace Tutorials.ObjectPool.Scripts.PoolUnity
{
    public class SpawnerUnity: MonoBehaviour
    {
        [SerializeField] private CoinUnity _prefabCoin;
        [SerializeField] private Transform _container;
        [SerializeField] private int _maxSize;
        [SerializeField] private int _defaultCapacity; // _startSizePool
        [SerializeField] private bool _collectionCheck;

        [Space] 
        [SerializeField] private float _timeToSpawn;
        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private float _horizontalScatter;
        
        private IObjectPool<CoinUnity> _pool;

        private float _time;
        

        private void Awake()
        {
            _pool = new ObjectPool<CoinUnity>(
                CreateElement,
                OnGet,
                OnRelease,
                OnDestroyElement,
                _collectionCheck,
                _defaultCapacity,
                _maxSize);
        }

        private CoinUnity CreateElement()
        {
            var element = Instantiate(_prefabCoin, _container);
            element.Pool = _pool;

            return element;
        }
        
        private void OnGet(CoinUnity coin)
        {
            coin.transform.position = GeneratePosition();
            coin.gameObject.SetActive(true);
            coin.Pool = _pool;
        }

        private void OnRelease(CoinUnity coin)
        {
            coin.gameObject.SetActive(false);
        }

        private void OnDestroyElement(CoinUnity coin)
        {
            
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

        private Vector3 GeneratePosition()
        {
            var position = _pointSpawn.position;
            
            var x = Random.Range(
                position.x - _horizontalScatter,
                position.x + _horizontalScatter);

            var newPosition = new Vector3(x, position.y, position.z);

            return newPosition;
        }

        private void OnDestroy()
        {
            _pool.Clear();
        }
    }
}