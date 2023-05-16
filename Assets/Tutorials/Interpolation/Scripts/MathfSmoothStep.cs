using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfSmoothStep : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;
        [SerializeField] private Transform _target;
        [SerializeField] private float _coefficient;
        [SerializeField] private bool _isStart;

        private float _startPos;
        private float _endPos;
        private float _time;
        private void Start()
        {
            _startPos = _objectMove.position.x;
            _endPos = _target.position.x;
        }

        private void Update()
        {
            if(!_isStart) return;

            if (_coefficient == 0) 
                _coefficient = 1;
            
            var x = Mathf.SmoothStep(_startPos, _endPos, _time/_coefficient);

            var position = _objectMove.position;
            position.x = x;
            
            _objectMove.position = position;

            _time += Time.deltaTime;
        }
    }
}