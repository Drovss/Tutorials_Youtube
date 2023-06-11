using DG.Tweening;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    public class BezierDOTweenDoPathExample : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        [SerializeField] private Transform _p0;
        [SerializeField] private Transform _p1;
        [SerializeField] private Transform _p2;
        [SerializeField] private Transform _p3;
        
        [SerializeField] private Transform _p4;
        [SerializeField] private Transform _p5;

        private Vector3 _startPoint;
        private void Start()
        {
            _startPoint = _transform.position;
            
            DoPathBezier();
        }
        
        private void DoPathBezier()
        {
            var duration = 5f;
            var resolution = 10;
            var pathPoint = new[]
            {
                _p0.position,
                _p1.position,
                _p2.position,
                _p3.position,
                _p4.position,
                _p5.position,
            };

            _transform.DOPath(
                    pathPoint,
                    duration,
                    PathType.CubicBezier,
                    PathMode.Sidescroller2D,
                    resolution,
                    Color.red)
                .SetLoops(-1);
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            
            Gizmos.DrawLine(_startPoint, _p1.position);
            Gizmos.DrawLine(_p0.position, _p4.position);
            Gizmos.DrawLine(_p0.position, _p2.position);
            Gizmos.DrawLine(_p3.position, _p5.position);
        }
    }
}