using System;
using UnityEngine;

namespace Tutorials.Sign.Scripts
{
    public class ExampleApproximately:MonoBehaviour
    {
        private float a = 2f;
        private float b = 10.0f / 5.0f;
        private void Start()
        {
            // Приблизне порівняння
            
            var approximately = Mathf.Approximately(a, b);
        }

        private void Update()
        {
            if (a == b)
                Debug.Log(true);
            else
                Debug.Log(false);

            #region var2

            // aльтернативне порівняння
            if (Math.Abs(a - b) < Mathf.Epsilon)
                Debug.Log(true);
            else
                Debug.Log(false);

            #endregion
            
        }
    }
}