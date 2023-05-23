using System.Globalization;
using TMPro;
using UnityEngine;

namespace Tutorials.Vector.Scripts
{
    public class VectorProject : MonoBehaviour
    {
        
        [SerializeField] private Transform _dot1;
        [SerializeField] private Transform _dot2;
        [SerializeField] private Transform _dot3;

        private void Update()
        {
            var project = Vector3.Project(_dot1.position, _dot2.position);

            _dot3.position = project;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Vector3.zero, _dot1.position);
            
            Gizmos.color = Color.red;
            Gizmos.DrawLine(Vector3.zero, _dot2.position);
            
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(Vector3.zero, _dot3.position);
        }
    }
}