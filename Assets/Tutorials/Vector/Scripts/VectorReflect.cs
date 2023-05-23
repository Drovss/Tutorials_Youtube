using UnityEngine;

namespace Tutorials.Vector.Scripts
{
    public class VectorReflect : MonoBehaviour
    {
        [SerializeField] private Transform _rootObject;
        [SerializeField] private bool _isUp;

        private Vector3 _reflectRight;
        private Vector3 _reflectUp;
        
        private void Update ()
        {
            if (_isUp)
            {
                _reflectUp = Vector3.Reflect(_rootObject.position, Vector3.up);
                _reflectRight = Vector3.zero;
            }
            else
            {
                _reflectRight = Vector3.Reflect(_rootObject.position, Vector3.right);
                _reflectUp = Vector3.zero;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Vector3.zero, _rootObject.position);
            
            Gizmos.color = Color.red;
            Gizmos.DrawLine(Vector3.zero, _reflectUp);
            
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(Vector3.zero, _reflectRight);
        }
    }
}