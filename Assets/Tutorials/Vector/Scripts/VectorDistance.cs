using UnityEngine;
using TMPro;

namespace Tutorials.Vector.Scripts
{
    public class VectorDistance : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textDistance;
        [SerializeField] private TextMeshProUGUI _textAngle;
        
        [SerializeField] private Transform _dot1;
        [SerializeField] private Transform _dot2;

        private void Update()
        {
            var distance = Vector3.Distance(_dot1.position, _dot2.position);
            _textDistance.SetText($"Distance: {distance}");

            var angle = Vector3.Angle(_dot1.position, _dot2.position);
            _textAngle.SetText($"Angle: {angle}");
        }
    }
}