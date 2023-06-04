using System;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    //[ExecuteAlways]
    public class MirrorPoint : MonoBehaviour
    {
        [SerializeField] private Transform _selfPoint;
        [SerializeField] private Transform _pointCenter;
        [SerializeField] private Transform _pointToMirror;

        private Vector3 _pos;
        
        private void Start()
        {
            _pos = _selfPoint.position;
        }
        
        private void Update()
        {
            //MovePosition();
        }

        private void OnDrawGizmos()
        {
            MovePosition();
        }

        private void MovePosition()
        {
            if (_selfPoint == null) return;
            if (_pointCenter == null) return;
            if (_pointToMirror == null) return;

            if (_selfPoint.position != _pos)
            {
                var dir = (_pointCenter.position - _selfPoint.position).normalized;
                var distance = Vector3.Distance(_selfPoint.position, _pointCenter.position);
                _pointToMirror.position = _pointCenter.position + (dir * distance);
            }

            _pos = _selfPoint.position;
        }
        
        private void OnDestroy()
        {
            _pos = Vector3.zero;
        }
    } 
}