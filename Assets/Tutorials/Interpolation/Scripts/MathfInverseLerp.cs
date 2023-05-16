using TMPro;
using UnityEngine;

namespace Tutorials.Interpolation.Scripts
{
    public class MathfInverseLerp : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        
        [SerializeField] private float _min;
        [SerializeField] private float _max;
        [SerializeField] private float _current;

        [SerializeField] private bool _isStart;

        private void Update()
        {
            if(!_isStart) return;
            
            var heals = Mathf.InverseLerp(_min, _max, _current);

            _text.SetText($"{heals * 100}%");
        }
    }
}