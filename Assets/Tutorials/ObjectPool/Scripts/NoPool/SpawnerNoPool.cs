using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.NoPool
{
    public class SpawnerNoPool : MonoBehaviour
    {
        [SerializeField] private CoinNoPool _prefabCoin;
        [SerializeField] private Transform _container;

        [Space] 
        [SerializeField] private float _timeToSpawn;
        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private float _horizontalScatter;
        
        private float _time;
        
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
            var coin = Instantiate(_prefabCoin, _container);
            coin.transform.position = GeneratePosition();
            coin.gameObject.SetActive(true);
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