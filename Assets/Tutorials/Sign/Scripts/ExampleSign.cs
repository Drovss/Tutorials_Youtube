using UnityEngine;

namespace Tutorials.Sign.Scripts
{
    public class ExampleSign:MonoBehaviour
    {
        private void Start()
        {
            float num1 = 4.5f;
            float num2 = -3.5f;
            
            //Знак числа
            
            var sign = Mathf.Sign(num1); // if num1 >= 0 return 1
            
            var sign2 = Mathf.Sign(num2); // if num2 < 0 return -1
        }

        private void Update()
        {
            if (Input.GetButton("Horizontal"))
            {
                // Повертання зі швидкістю 90/-90 градусів в секунду
                
                var axis = Vector3.forward; // вісь поворота
                var sign = Mathf.Sign(Input.GetAxis("Horizontal")); // знак поворота
                var angle = 90; // кут поворота

                transform.Rotate(axis * (sign * angle * Time.deltaTime)); 
            }
        }
    }
}