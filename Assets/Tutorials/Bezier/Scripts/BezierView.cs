using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    public class BezierView : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        [SerializeField] private Transform _p0;
        [SerializeField] private Transform _p1;
        [SerializeField] private Transform _p2;
        [SerializeField] private Transform _p3;

        [SerializeField] [Range(0,1)] private float _t;
        
        private void Update()
        {
            _transform.position = Bezier.BezierLerp(
                _p0.position, 
                _p1.position, 
                _p2.position, 
                _p3.position,
                _t);
        }
        
        private void OnDrawGizmos() {

            const int segmentsNumber = 20;
            Vector3 previousPoint = _p0.position;

            for (int i = 0; i < segmentsNumber + 1; i++) 
            {
                float parameter = (float)i / segmentsNumber;
                
                Vector3 point = Bezier.BezierLerp(
                    _p0.position, 
                    _p1.position, 
                    _p2.position, 
                    _p3.position, 
                    parameter);
                
                Gizmos.DrawLine(previousPoint, point);
                previousPoint = point;

                Gizmos.DrawLine(_p0.position, _p1.position);
                Gizmos.DrawLine(_p1.position, _p2.position);
                Gizmos.DrawLine(_p2.position, _p3.position);
            }

        }
    }
}