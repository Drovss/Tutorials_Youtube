using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Tutorials.Sign.Scripts
{
    public class ExampleSmoothDamp:MonoBehaviour
    {
        [SerializeField] private Transform _target;
        
        private float _velocityY = 0.0f; 
        private float _smoothTime = 0.5f;
        
        private void Update()
        {
            var position = transform.position;

            var newPositionY = Mathf.SmoothDamp(
                position.y, 
                _target.position.y, 
                ref _velocityY, 
                _smoothTime);
            
            position = new Vector3 (position.x, newPositionY, position.z);
            transform.position = position;
        }
    }
}