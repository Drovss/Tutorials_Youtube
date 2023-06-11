using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    [ExecuteAlways]
    public class BezierExample : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        [SerializeField] private Transform _p0;
        [SerializeField] private Transform _p1;
        [SerializeField] private Transform _p2;
        [SerializeField] private Transform _p3;

        [SerializeField] [Range(0,1)] private float _t;

        private Vector3 _p01;
        private Vector3 _p12;
        private Vector3 _p23;
        
        private Vector3 _p012;
        private Vector3 _p123;
        
        private Vector3 _p0123;
        
        private void Update()
        {
            _transform.position = BezierPosition(
                _p0.position, 
                _p1.position, 
                _p2.position, 
                _p3.position, 
                _t);
        }

        private Vector3 BezierPosition(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
        {
            t = Mathf.Clamp01(t);

            _p01 = Vector3.Lerp(p0, p1, t);
            _p12 = Vector3.Lerp(p1, p2, t);
            _p23 = Vector3.Lerp(p2, p3, t);

            _p012 = Vector3.Lerp(_p01, _p12, t);
            _p123 = Vector3.Lerp(_p12, _p23, t);

            _p0123 = Vector3.Lerp(_p012, _p123, t);

            return _p0123;
        }

        private void OnDrawGizmos() 
        {
            // відображення кривої Безьє
            const int segmentsNumber = 20;

            Vector3 previousPoint = _p0.position;

            for (int i = 0; i < segmentsNumber + 1; i++) 
            {
                float parameter = (float)i / segmentsNumber;
                
                Vector3 point = BezierPosition(
                    _p0.position, 
                    _p1.position, 
                    _p2.position, 
                    _p3.position, 
                    parameter);
                
                Gizmos.DrawLine(previousPoint, point);
                previousPoint = point;
            }

            // відображення точок і ліній між точками
            
            const float radius = 0.2f;
            
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(_p0.position, _p1.position);
            Gizmos.DrawLine(_p1.position, _p2.position);
            Gizmos.DrawLine(_p2.position, _p3.position);
                
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(_p01, radius);
            Gizmos.DrawSphere(_p12, radius);
            Gizmos.DrawSphere(_p23, radius);
            Gizmos.DrawLine(_p01, _p12);
            Gizmos.DrawLine(_p12, _p23);
                
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_p012, radius);
            Gizmos.DrawSphere(_p123, radius);
            Gizmos.DrawLine(_p012, _p123);
        }
    }
}