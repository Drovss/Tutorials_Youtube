using System;
using UnityEngine;

namespace Tutorials.Sqrt.Scripts
{
    public class Example: MonoBehaviour
    {
        private void Start()
        {
            Mathf.Sqrt(25); // Корінь

            Mathf.Pow(2, 4); // Степінь

            Mathf.Exp(4); // експонента в степені

            Mathf.Log(25, 5); // логарифм

            Mathf.Log(20); // натуральний логарифм (основа експонента)

            Mathf.Log10(20); // логарифм з основою 10

            Mathf.Abs(-10); // модуль числа

            Mathf.Min(3, 6); // мінімальне число з двох
            Mathf.Max(4, 3); // максимальне число з двох

            var currentHealth = 10;
            var maxHealth = 20;
            currentHealth = Mathf.Min(currentHealth, maxHealth);
            currentHealth = Mathf.Max(currentHealth, 0);

            var arr = new int[3] { 2, 5, 5};

            Mathf.Min(arr);
            Mathf.Max(arr);

            Mathf.Ceil(2.4f);  // 2.4 -> 2, -1.3 -> -2

            Mathf.Floor(2.4f); // 2.4 -> 3, -1,3 -> -1

            Mathf.Round(2.4f); // 2.4 -> 2, 2.7 -> 3

            // 1.5 -> 2, 4.5 -> 4


            Mathf.CeilToInt(2.4f);  // 2.4 -> 2, -1.3 -> -2

            Mathf.FloorToInt(2.4f); // 2.4 -> 3, -1,3 -> -1

            Mathf.RoundToInt(2.4f); // 2.4 -> 2, 2.7 -> 3

        }
    }
}