using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    public static class Bezier
    {
        public static Vector3 BezierLerp(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
        {
            t = Mathf.Clamp01(t);
            
            var p01 = Vector3.Lerp(p0, p1, t);
            var p12 = Vector3.Lerp(p1, p2, t);
            var p23 = Vector3.Lerp(p2, p3, t);
            
            var p012 = Vector3.Lerp(p01, p12, t);
            var p123 = Vector3.Lerp(p12, p23, t);
            
            var p0123 = Vector3.Lerp(p012, p123, t);
            
            return p0123;
        }
        
        public static Vector3 BezierLerp(Vector3 p0, Vector3 p1, Vector3 p2, float t)
        {
            t = Mathf.Clamp01(t);
            
            var p01 = Vector3.Lerp(p0, p1, t);
            var p12 = Vector3.Lerp(p1, p2, t);
            
            var p012 = Vector3.Lerp(p01, p12, t);
            
            return p012;
        }
        
        public static Vector3 BezierFormula(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
        {
            t = Mathf.Clamp01(t);
            
            float oneMinusT = 1f - t;
            
            return
                oneMinusT * oneMinusT * oneMinusT * p0 +
                3f * oneMinusT * oneMinusT * t * p1 +
                3f * oneMinusT * t * t * p2 +
                t * t * t * p3;
        }
        
        public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) 
        {
            t = Mathf.Clamp01(t);
            
            float oneMinusT = 1f - t;
            
            return
                3f * oneMinusT * oneMinusT * (p1 - p0) +
                6f * oneMinusT * t * (p2 - p1) +
                3f * t * t * (p3 - p2);
        }
    }
}