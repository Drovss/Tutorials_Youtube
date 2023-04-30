using UnityEngine;

namespace Tutorials.Sign.Scripts
{
    public class ExampleClamp: MonoBehaviour
    {
        private void Start()
        {
            float num = 5f;
            float min = 0f;
            float max = 10f;
            
            // Обмеження

            var clamp = Mathf.Clamp(num, min, max);

            var clamp01 = Mathf.Clamp01(num);
            
            // приклад Clamp
            var heals = 10f;
            heals = Mathf.Clamp(heals, min, max);
            
            // приклад Clamp01
            var percent = Mathf.Clamp01(num) * 100;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            var pos = transform.position;
            
            float min = -2; 
            float max = 2;

            var position = other.transform.position;

            float x = Mathf.Clamp(position.x, pos.x + min, pos.x + max);
            float y = Mathf.Clamp(position.y, pos.y + min, pos.y + max);

            position = new Vector3(x, y, position.z);
            
            other.transform.position = position;
        }
    }
}