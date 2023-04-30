using UnityEngine;

namespace Tutorials.Sign.Scripts
{
    public class ExampleSmoothDampAngle: MonoBehaviour
    {
        private float _targetAngle = 90.0f;
        private float _velocityZ = 0;
        private float _smoothTime = 0.5f;
	
        void Update()
        {
            float angle = Mathf.SmoothDampAngle(
                transform.eulerAngles.z,
                _targetAngle,
                ref _velocityZ,
                _smoothTime);

            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.z, angle);
        }
    }
}