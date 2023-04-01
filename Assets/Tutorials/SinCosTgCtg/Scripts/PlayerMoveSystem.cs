using UnityEngine;

namespace Tutorials.SinCosTgCtg.Scripts
{
    public class PlayerMoveSystem : MonoBehaviour
    {
        [SerializeField] private Transform _rootTransform;
        [SerializeField] private Transform _viewTransform;
        
        [SerializeField] private float _speed;

        private void Update()
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                _rootTransform.Translate(Vector3.right * (Time.deltaTime * _speed));
                _viewTransform.eulerAngles = new Vector3(0, 0, 270);
            }
            
            if (Input.GetAxis("Horizontal") < 0)
            {
                _rootTransform.Translate(Vector3.left * (Time.deltaTime * _speed));
                _viewTransform.eulerAngles = new Vector3(0, 0, 90);
            }
            
            if (Input.GetAxis("Vertical") > 0)
            {
                _rootTransform.Translate(Vector3.up * (Time.deltaTime * _speed));
                _viewTransform.eulerAngles = new Vector3(0, 0, 0);
            }
            
            if (Input.GetAxis("Vertical") < 0)
            {
                _rootTransform.Translate(Vector3.down * (Time.deltaTime * _speed));
                _viewTransform.eulerAngles = new Vector3(0, 0, 180);
            }
        }
    }
}