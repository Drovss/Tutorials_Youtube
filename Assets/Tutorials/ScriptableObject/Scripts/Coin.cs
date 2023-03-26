using UnityEngine;
using UnityEngine.Pool;

namespace Tutorials.ScriptableObject.Scripts
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        public IObjectPool<Coin> Pool { get; set; }
        
        public float DestroyPositionY { get; set; }

        private void Update()
        {
            if (transform.position.y < DestroyPositionY)
            {
                Pool?.Release(this);
            }
        }

        public void SetSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }
    }
}