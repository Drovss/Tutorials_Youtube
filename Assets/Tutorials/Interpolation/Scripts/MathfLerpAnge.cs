using System;
using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfLerpAnge : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;

        [SerializeField] private float _maxAngle;

        [SerializeField] private bool _isStart;
        
        private float _minAngle;
        private float _time;

        private void Start()
        {
            _minAngle = _objectMove.eulerAngles.z;
            _maxAngle += _minAngle;
        }

        private void Update()
        {
            if(!_isStart) return;
            
            
            var angel = Mathf.LerpAngle(_minAngle, _maxAngle, _time);

            var eulerAngles = _objectMove.eulerAngles;
            eulerAngles.z = angel;
            
            _objectMove.eulerAngles = eulerAngles;

            _time += Time.deltaTime;
        }
    }
}