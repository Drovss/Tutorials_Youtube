using System;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    //[ExecuteAlways]
    public class CenterPoint : MonoBehaviour
    {
        [SerializeField] private Transform _selfPoint;
        [SerializeField] private Transform _pointLeft;
        [SerializeField] private Transform _pointRight;

        private Vector3 _pos;

        private void Start()
        {
            _pos = _selfPoint.position;
        }

        private void Update()
        {
           // MovePosition();
        }

        private void MovePosition()
        {
            if (_selfPoint == null) return;

            if (_selfPoint.position != _pos)
            {
                var dir = _selfPoint.position - _pos;

                if (_pointLeft != null)
                    _pointLeft.position += dir;

                if (_pointRight != null)
                    _pointRight.position += dir;
            }

            _pos = _selfPoint.position;
        }

        private void OnDrawGizmos()
        {
            MovePosition();
        }

        private void OnDestroy()
        {
            _pos = Vector3.zero;
        }
    }
}