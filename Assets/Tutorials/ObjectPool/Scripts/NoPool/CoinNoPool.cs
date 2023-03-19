using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.NoPool
{
    public class CoinNoPool: MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
 
        private void Update()
        {
            if (transform.position.y < _mixPositionY)
            {
                Destroy(gameObject);
            }
        }
    }
}