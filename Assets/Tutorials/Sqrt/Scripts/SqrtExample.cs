using System;
using UnityEngine;
using UnityEngine.UI;

namespace Tutorials.Sqrt.Scripts
{
    public class SqrtExample: MonoBehaviour
    {
        [SerializeField] private Transform _transform1;
        [SerializeField] private Transform _transform2;

        [SerializeField] private Button _button;

        private void Start()
        {
            _button.onClick.AddListener(Distance);
        }

        private void Distance()
        {
            // отримуємо квадрат відстані між точками
            var d = _transform1.position - _transform2.position;
            // отримуємо квадрат відстані по Х
            var sqrtX = d.x * d.x;
            // отримуємо квадрат відстані по У
            var sqrtY = d.y * d.y;
            // вираховуємо дистанцію між точками
            var distance = Mathf.Sqrt(sqrtX + sqrtY);

            Debug.Log($"distance: {distance}");
        }
    }
}