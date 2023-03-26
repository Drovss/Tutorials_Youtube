using System.Collections.Generic;
using UnityEngine;

namespace Tutorials.ScriptableObject.Scripts
{
    [CreateAssetMenu(menuName = "Settings/elements", fileName = "NewElements")]
    public class ElementData: UnityEngine.ScriptableObject
    {
        [SerializeField] private List<Element> _elements;

        public List<Element> Elements => _elements;
    }
}