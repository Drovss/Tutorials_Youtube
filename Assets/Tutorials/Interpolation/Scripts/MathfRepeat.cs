using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfRepeat : MonoBehaviour
    {
        [SerializeField] private Transform _objectMove;
        [SerializeField] private Transform _target;
        
        [SerializeField] private bool _isStart;
        
        private float _time;
        
        private void Update()
        {
            if(!_isStart) return;

            var x = Mathf.Repeat(_time, _target.position.x);

            var position = _objectMove.position;
            position.x = x;

            _objectMove.position = position;

            _time += Time.deltaTime;
        }
    }
}