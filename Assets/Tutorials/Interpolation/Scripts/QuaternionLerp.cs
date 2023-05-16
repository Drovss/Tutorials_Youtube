using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class QuaternionLerp : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;

        [SerializeField] private float _maxAngle;

        [SerializeField] private bool _isStart;
        
        private Quaternion _start;
        private Quaternion _end;
        
        private float _minAngle;
        private float _time;

        private void Start()
        {
            _start = Quaternion.identity;
            _end = Quaternion.Euler (0f, 0f, _maxAngle);
        }

        private void Update()
        {
            if(!_isStart) return;

            _objectMove.rotation = Quaternion.Lerp(_start, _end, Mathf.PingPong(_time, 1f));

            //_objectMove.rotation = Quaternion.LerpUnclamped(_start, _end, _time);
            
            //_objectMove.rotation = Quaternion.Slerp(_start, _end, _time);
            
            //_objectMove.rotation = Quaternion.SlerpUnclamped(_start, _end, _time);

            _time += Time.deltaTime;
        }
    }
}