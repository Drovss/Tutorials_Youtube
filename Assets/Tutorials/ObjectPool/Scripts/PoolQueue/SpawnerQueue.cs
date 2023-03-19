using UnityEngine;
using Random = UnityEngine.Random;

namespace Tutorials.ObjectPool.Scripts.PoolQueue
{
    public class SpawnerQueue: MonoBehaviour
    {
        [SerializeField] private CoinQueue _prefabCoin;
        [SerializeField] private Transform _container;
        [SerializeField] private int _startSizePool;
        [SerializeField] private int _expansionStepPool;

        [Space] 
        [SerializeField] private float _timeToSpawn;
        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private float _horizontalScatter;
        
        private MonoPoolQueue<CoinQueue> _pool;

        private float _time;
        
        private void Awake()
        {
            _pool = new MonoPoolQueue<CoinQueue>(_prefabCoin, _container, _startSizePool, _expansionStepPool);
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
            var coin = _pool.Get();
            coin.transform.position = GeneratePosition();
            coin.gameObject.SetActive(true);
            coin.Pool = _pool;
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