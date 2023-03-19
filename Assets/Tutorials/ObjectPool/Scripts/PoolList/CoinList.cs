using UnityEngine;

namespace Tutorials.ObjectPool.Scripts.PoolList
{
    public class CoinList: MonoBehaviour
    {
        [SerializeField] private float _mixPositionY;
        
        public MonoPoolList<CoinList> Pool { get; set; }

        private void Update()
        {
            if (transform.position.y < _mixPositionY)
            {
                Pool?.Release(this);
            }
        }
    }
}