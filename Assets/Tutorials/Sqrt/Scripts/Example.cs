using System;
using UnityEngine;

namespace Tutorials.Sqrt.Scripts
{
    public class Example: MonoBehaviour
    {
        private void Start()
        {
           Mathf.Sqrt(25); // Корінь
           Debug.Log("Mathf.Sqrt(25) = " + Mathf.Sqrt(25));

            Mathf.Pow(2, 4); // Степінь
            Debug.Log("Mathf.Pow(2, 4) = " + Mathf.Pow(2, 4));

            Mathf.Exp(4); // експонента в степені
            Debug.Log("Mathf.Exp(4) = " + Mathf.Exp(4));

            Mathf.Log(25, 5); // логарифм
            Debug.Log("Mathf.Log(25, 5) = " + Mathf.Log(25, 5));

            Mathf.Log(20); // натуральний логарифм (основа експонента)
            Debug.Log("Mathf.Log(20) = " + Mathf.Log(20));

            Mathf.Log10(20); // логарифм з основою 10
            Debug.Log("Mathf.Log10(20) = " + Mathf.Log10(20));

            Mathf.Abs(-10); // модуль числа
            Debug.Log("Mathf.Abs(-10) = " + Mathf.Abs(-10));

            Mathf.Min(3, 6); // мінімальне число з двох
            Debug.Log("Mathf.Min(3, 6) = " + Mathf.Min(3, 6));
            
            Mathf.Max(4, 3); // максимальне число з двох
            Debug.Log("Mathf.Max(4, 3) = " + Mathf.Max(4, 3));

            var currentHealth = 10;
            var maxHealth = 20;
            currentHealth = Mathf.Min(currentHealth, maxHealth);
            currentHealth = Mathf.Max(currentHealth, 0);

            var arr = new int[3] { 2, 5, 5};
            Debug.Log("arr = " + arr);

            Mathf.Min(arr);
            Debug.Log("Mathf.Min(arr) = " + Mathf.Min(arr));
            
            Mathf.Max(arr);
            Debug.Log("Mathf.Max(arr) = " + Mathf.Max(arr));

            Mathf.Ceil(2.4f);  // 2.4 -> 2, -1.3 -> -2
            Debug.Log("Mathf.Ceil(2.4f) = " + Mathf.Ceil(2.4f));

            Mathf.Floor(2.4f); // 2.4 -> 3, -1,3 -> -1
            Debug.Log("Mathf.Floor(2.4f) = " + Mathf.Floor(2.4f));

            Mathf.Round(2.4f); // 2.4 -> 2, 2.7 -> 3
            Debug.Log("Mathf.Round(2.4f) = " + Mathf.Round(2.4f));

            // 1.5 -> 2, 4.5 -> 4


            Mathf.CeilToInt(2.4f);  // 2.4 -> 2, -1.3 -> -2
            Debug.Log("Mathf.CeilToInt(2.4f) = " + Mathf.CeilToInt(2.4f));

            Mathf.FloorToInt(2.4f); // 2.4 -> 3, -1,3 -> -1
            Debug.Log("Mathf.FloorToInt(2.4f) = " + Mathf.FloorToInt(2.4f));

            Mathf.RoundToInt(2.4f); // 2.4 -> 2, 2.7 -> 3
            Debug.Log("Mathf.RoundToInt(2.4f) = " + Mathf.RoundToInt(2.4f));

        }
    }
}