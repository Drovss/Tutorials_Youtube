using UnityEngine;
using UnityEngine.Pool;

namespace Tutorials.ObjectPool.Scripts.PoolUnity
{
    public class CoinUnity:MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
        
        public IObjectPool<CoinUnity> Pool { get; set; }

        private void Update()
        {
            if (transform.position.y < _mixPositionY)
            {
                Pool?.Release(this);
            }
        }
    }
}