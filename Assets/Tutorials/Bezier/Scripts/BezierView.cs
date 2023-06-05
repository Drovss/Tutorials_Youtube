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
            _transform.position = Bezier.BezierFormula(
                _p0.position, 
                _p1.position, 
                _p2.position, 
                _p3.position,
                _t);
            
            // _transform.rotation = Quaternion.LookRotation(Bezier.GetFirstDerivative(
            //     _p0.position, 
            //     _p1.position, 
            //     _p2.position, 
            //     _p3.position,
            //     _t));
        }
    }
}