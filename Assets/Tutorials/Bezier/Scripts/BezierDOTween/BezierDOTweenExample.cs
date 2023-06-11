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

        [SerializeField] [Range(0,1)] private float _t;

        private void Start()
        {
            GetSegmentPointCloud1();
            //GetSegmentPointCloud2();
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

        private void GetSegmentPointCloud1()
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

        private void GetSegmentPointCloud2()
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

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            
            Gizmos.DrawLine(_p0.position, _p1.position);
            Gizmos.DrawLine(_p1.position, _p3.position);
            Gizmos.DrawLine(_p2.position, _p3.position);

            DrawBezier();
        }

        private void DrawBezier()
        {
            Gizmos.color = Color.red;
            
            // відображення кривої Безьє
            const int segmentsNumber = 20;

            var points = DOCurve.CubicBezier.GetSegmentPointCloud(
                _p0.position, 
                _p1.position, 
                _p2.position, 
                _p3.position, 
                segmentsNumber);
            
            for (int i = 0; i < points.Length - 1; i++)
            {
                var previousPoint = points[i];
                Gizmos.DrawLine(previousPoint, points[i + 1]);
            }
        }
    }
}