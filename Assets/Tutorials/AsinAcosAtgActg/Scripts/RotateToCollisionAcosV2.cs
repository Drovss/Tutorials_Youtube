using UnityEngine;

namespace Tutorials.AsinAcosAtgActg.Scripts
{
    public class RotateToCollisionAcosV2 : MonoBehaviour
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
            
            var angle = Mathf.Acos(directionPosNorm.y) * Mathf.Rad2Deg;
            
            if(directionPosNorm.x > 0)
            {
                angle = -angle;
            }

            _rotateTransform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}