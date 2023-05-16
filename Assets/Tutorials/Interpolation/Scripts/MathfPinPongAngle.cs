using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfPinPongAngle : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;
        
        [SerializeField] private float _maxAngle;
        [SerializeField] private float _coefficient;
        
        [SerializeField] private bool _isStart;
        
        private float _time;
        
        private void Update()
        {
            if(!_isStart) return;

            var z = Mathf.PingPong(_time * _coefficient, _maxAngle);

            var position = _objectMove.position;
            position.z = z;

            _objectMove.eulerAngles = position;

            _time += Time.deltaTime;
        }
    }
}