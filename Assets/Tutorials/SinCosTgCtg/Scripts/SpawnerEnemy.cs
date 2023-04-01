using UnityEngine;

namespace Tutorials.SinCosTgCtg.Scripts
{
    public class SpawnerEnemy : MonoBehaviour
    {
        [SerializeField] private Object _enemyPrefab;
        
        [SerializeField] private float _distance = 3;
        
        [SerializeField] private float _angle = 360;
        
        [SerializeField] private int _count = 15;

        private void Start ()
        {
            _angle *= Mathf.Deg2Rad;
            
            for(int i = 0; i < _count; i++)
            {
                var point = transform.position;

                point.x += Mathf.Cos(_angle / _count * i) * _distance;
                point.y += Mathf.Sin(_angle / _count * i) * _distance;

                Instantiate(_enemyPrefab, point, Quaternion.identity);
            }
        }
    }
}