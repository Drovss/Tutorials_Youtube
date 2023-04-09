using UnityEngine;

namespace Tutorials.AsinAcosAtgActg.Scripts
{
    public class RotateToCollisionAtan2 : MonoBehaviour
    {
        [SerializeField] private Transform _rotateTransform;
        
        private Transform _target;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            _target = other.transform;
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            _target = null;
        }

        private void Update()
        {
            if(_target == null) return;

            var directionPos = _target.position - _rotateTransform.position;

            var directionPosNorm = directionPos.normalized;
            
            var angle = Mathf.Atan2(-directionPosNorm.x, directionPosNorm.y) * Mathf.Rad2Deg;
            
            _rotateTransform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}