using System;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    [Serializable]
    public class BezierElement
    {
        public Transform StartPoint;
        public Transform SecondPoint;
        public Transform ThirdPoint;
        public Transform EndPoint;

        public Vector3 BezierPosition(float t)
        {
            var position = Bezier.BezierLerp(
                StartPoint.position,
                SecondPoint.position,
                ThirdPoint.position,
                EndPoint.position,
                t);

            return position;
        }

    public void ViewGizmos()
        {
            const int segmentsNumber = 20;
            Vector3 previousPoint = StartPoint.position;

            for (int i = 0; i < segmentsNumber + 1; i++) 
            {
                float parameter = (float)i / segmentsNumber;
                
                Vector3 point = Bezier.BezierLerp(
                    StartPoint.position, 
                    SecondPoint.position, 
                    ThirdPoint.position, 
                    EndPoint.position, 
                    parameter);
                Gizmos.color = Color.red;
                Gizmos.DrawLine(previousPoint, point);
                previousPoint = point;
            }
            
            Gizmos.color = Color.green;
            Gizmos.DrawLine(StartPoint.position, SecondPoint.position);
            Gizmos.DrawLine(ThirdPoint.position, EndPoint.position);
        }
    }
}