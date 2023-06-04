using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    public class BezierDOTweenExample : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        [SerializeField] private Transform _p0;
        [SerializeField] private Transform _p1;
        [SerializeField] private Transform _p2;
        [SerializeField] private Transform _p3;
        
        [SerializeField] private Transform _p4;
        [SerializeField] private Transform _p5;

        [SerializeField] [Range(0,1)] private float _t;

        private void Start()
        {
            //NewMethod();
            //NewMethod2();
            DoPathBezier();
        }

        private void Update()
        {
            _transform.position = DOCurve.CubicBezier.GetPointOnSegment(
                _p0.position,
                _p1.position,
                _p2.position,
                _p3.position,
                _t);
        }

        private void NewMethod2()
        {
            var arr = DOCurve.CubicBezier.GetSegmentPointCloud(
                _p0.position,
                _p1.position,
                _p2.position,
                _p3.position,
                10);
            
            foreach (var t in arr)
            {
                var obj = Instantiate(_transform);
                obj.position = t;
            }
        }

        private void NewMethod()
        {
            var list = new List<Vector3>();

            DOCurve.CubicBezier.GetSegmentPointCloud(
                list,
                _p0.position,
                _p1.position,
                _p2.position,
                _p3.position,
                10);

            foreach (var t in list)
            {
                var obj = Instantiate(_transform);
                obj.position = t;
            }
        }

        private void DoPathBezier()
        {
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
                    5f,
                    PathType.CubicBezier,
                    PathMode.Sidescroller2D,
                    10,
                    Color.red)
                .SetLoops(-1);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(_p0.position, _p4.position);
            Gizmos.DrawLine(_p0.position, _p2.position);
            Gizmos.DrawLine(_p3.position, _p5.position);
        }
    }
}