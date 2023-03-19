using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.PoolQueue
{
    public class Coin: MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
        
        public MonoPoolQueue<Coin> Pool { get; set; }

        private void Update()
        {
            if (transform.position.y < _mixPositionY)
            {
                Pool?.Release(this);
            }
        }
    }
}