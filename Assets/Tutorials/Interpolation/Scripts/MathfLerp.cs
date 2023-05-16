using System;
using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfLerp : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;
        [SerializeField] private Transform _target;
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
            
            
            var x = Mathf.Lerp(_startPos, _endPos, _time); //a + (ba) * t, де 0 <= t <= 1.
            
            //var x = Mathf.LerpUnclamped(_startPos, _endPos, _time);

            var position = _objectMove.position;
            position.x = x;
            
            _objectMove.position = position;

            _time += Time.deltaTime;
        }
    }
}