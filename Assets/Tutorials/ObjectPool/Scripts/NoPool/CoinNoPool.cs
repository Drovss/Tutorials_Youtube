using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.NoPool
{
    public class CoinNoPool: MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
        [SerializeField] private bool _isDestroy;
 
        private void Update()
        {
            if (transform.position.y < _mixPositionY && _isDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}