using System;
using UnityEngine;

namespace Tutorials.SinCosTgCtg.Scripts
{
    public class Tests : MonoBehaviour
    {
        private void Start()
        {
            #region MyRegion

            float rad = 1f;

            var deg = rad * Mathf.Rad2Deg;

            Debug.Log("deg " + deg );

            deg = 30f;
            
            rad = deg * Mathf.Deg2Rad;
            
            Debug.Log("rad " + rad );

            #endregion

            Mathf.Sin(1f);

            Mathf.Cos(2f);

            var tg = Mathf.Tan(2f);

            var ctg = 1 / tg;



        }
    }
}