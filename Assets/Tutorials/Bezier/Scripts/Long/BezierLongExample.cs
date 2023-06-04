using System.Collections.Generic;
using UnityEngine;

namespace Tutorials.Bezier.Scripts
{
    public class BezierLongExample : MonoBehaviour
    {
        [SerializeField] private List<BezierElement> _elements;
        [SerializeField] private Transform _transform;
        [SerializeField] [Range(0,1)] private float _t;

        private float _time;
        private int _index;

        private void Start()
        {
            _index = 0;
        }

        private void Update()
        {
            _transform.position = _elements[_index].BezierPosition(_time);

            if (_time > 1)
            {
                _index++;
                _time = 0;
                
                if (_index >= _elements.Count)
                    _index = 0;
            }
            
            _time += Time.deltaTime;
        }

        private void OnDrawGizmos()
        {
            foreach (var element in _elements)
            {
               element.ViewGizmos();
            }
        }
    }
}