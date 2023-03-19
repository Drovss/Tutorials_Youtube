using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.PoolQueue
{
    public class CoinQueue: MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
        
        public MonoPoolQueue<CoinQueue> Pool { get; set; }

        private void Update()
        {
            if (transform.position.y < _mixPositionY)
            {
                Pool?.Release(this);
            }
        }
    }
}