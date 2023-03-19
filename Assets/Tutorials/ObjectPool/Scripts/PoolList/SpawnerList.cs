using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.PoolList
{
    public class SpawnerList: MonoBehaviour
    {
        [SerializeField] private CoinList _prefabCoin;
        [SerializeField] private Transform _container;
        [SerializeField] private int _startSizePool;
        [SerializeField] private bool _autoExpand = true;

        [Space] 
        [SerializeField] private float _timeToSpawn;
        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private float _horizontalScatter;
        
        private MonoPoolList<CoinList> _pool;

        private float _time;
        
        private void Awake()
        {
            _pool = new MonoPoolList<CoinList>(_prefabCoin, _startSizePool, _container, _autoExpand);
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
    }
}