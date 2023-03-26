using System;
using UnityEngine;

namespace Tutorials.ScriptableObject.Scripts
{
    [Serializable]
    public class Element
    {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _sprite;
        [SerializeField] private float _destroyPositionY;


        public string ID => _id;

        public Sprite Sprite => _sprite;

        public float DestroyPositionY => _destroyPositionY;
    }
}