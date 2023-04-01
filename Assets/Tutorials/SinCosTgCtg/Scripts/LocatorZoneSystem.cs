using System.Collections.Generic;
using UnityEngine;

namespace Tutorials.SinCosTgCtg.Scripts
{
    public class LocatorZoneSystem : MonoBehaviour
    {
        [SerializeField] private Transform _gunTransform;

        [SerializeField] private List<SpriteRenderer> _lampZone;

        [SerializeField] private Color _colorDefault;
        [SerializeField] private Color _colorActive;

        private void OnTriggerEnter2D(Collider2D other)
        {
            var enemy = other.transform;
            
            _gunTransform.up = enemy.position - _gunTransform.position;
            
            var angle = _gunTransform.rotation.eulerAngles.z * Mathf.Deg2Rad;
            
            SetColorInZone(angle, _colorActive);
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            var angle = _gunTransform.rotation.eulerAngles.z * Mathf.Deg2Rad;

            SetColorInZone(angle, _colorDefault);
        }

        private void SetColorInZone(float angle, Color color)
        {
            if (Mathf.Cos(angle) > 0)
            {
                if (Mathf.Tan(angle) > 0)
                {
                    _lampZone[0].color = color;
                }
                else
                {
                    _lampZone[1].color = color;
                }
            }
            else
            {
                if (Mathf.Tan(angle) > 0)
                {
                    _lampZone[2].color = color;
                }
                else
                {
                    _lampZone[3].color = color;
                }
            }
        }
    }
}