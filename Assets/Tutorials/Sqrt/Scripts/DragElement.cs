using UnityEngine;

namespace Tutorials.Sqrt.Scripts
{
    public class DragElement: MonoBehaviour
    {
        private Camera _camera;
        private Vector3 _mousePosition;

        private void Start()
        {
            _camera = Camera.main;
        }

        private Vector3 GetTransformScreenPointPosition()
        {
            return _camera.WorldToScreenPoint(transform.position);
        }

        private void OnMouseDown()
        {
            _mousePosition = Input.mousePosition - GetTransformScreenPointPosition();
        }

        private void OnMouseDrag()
        {
            transform.position = _camera.ScreenToWorldPoint(Input.mousePosition - _mousePosition);
        }
    }
}