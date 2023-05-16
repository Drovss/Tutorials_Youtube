﻿using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class VectorSlerp : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;
        [SerializeField] private Transform _target;
        [SerializeField] private bool _isStart;

        private Vector3 _startPos;
        private Vector3 _endPos;
        private float _time;
        private void Start()
        {
            _startPos = _objectMove.position;
            _endPos = _target.position;
        }

        private void Update()
        {
            if(!_isStart) return;

            _objectMove.position = Vector3.Slerp(_startPos, _endPos, _time);
            
            //_objectMove.position = Vector3.SlerpUnclamped(_startPos, _endPos, _time);

            _time += Time.deltaTime;
        }
    }
}