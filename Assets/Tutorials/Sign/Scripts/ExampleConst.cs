using UnityEngine;

namespace Tutorials.Sign.Scripts
{
    public class ExampleConst: MonoBehaviour
    {
        private void Start()
        {
            #region PI

            var pi = Mathf.PI; // 3.14159274f;

            #endregion

            #region Infinity

            var inf = Mathf.Infinity; // додатня безкінечність
            
            var infNeg = Mathf.NegativeInfinity; // від'ємна безкінечність

            #endregion

            #region Rad

            var rad = Mathf.Deg2Rad; // 0.0174532924f;  Pi/180; переведення кута з градусів в радіани
            
            var deg = Mathf.Rad2Deg; // 57.29578f;  180/Pi; переведення кута з радіан в градуси

            #endregion

            #region Epsilon

            var eps = Mathf.Epsilon; // 1.401298E-45f; Погрішність

            #endregion
        }
    }
}