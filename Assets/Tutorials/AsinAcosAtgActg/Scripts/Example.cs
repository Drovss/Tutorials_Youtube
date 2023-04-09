using UnityEngine;

namespace Tutorials.AsinAcosAtgActg.Scripts
{
    public class Example : MonoBehaviour
    {
        private void Start()
        {
            float sin = 0.5f;
            float cos = 0.5f;
            float tg = 0.5f;
            float ctg = 0.5f;
            
            #region Arcsin_Arccos

            var asin = Mathf.Asin(sin);    // Арксинус
            var acos = Mathf.Acos(cos);    // Арккосинус

            #endregion

            #region Arctan
            
            var atan = Mathf.Atan(tg);		            //Арктангенс
            var atan2 = Mathf.Atan2(sin, cos);      //Арктангенс

            #endregion

            #region Arcctg

            var actg = 90 * Mathf.Deg2Rad - Mathf.Atan(ctg);	           //Арккотангенс
            var actg2 = 90 * Mathf.Deg2Rad - Mathf.Atan2(cos, sin);    //Арккотангенс

            #endregion
            
            #region Arcctg_v2

            var actg_v2 = 90 - Mathf.Atan(ctg) * Mathf.Rad2Deg;			    //Арккотангенс
            var actg2_2 = 90 - Mathf.Atan2(cos, sin) * Mathf.Rad2Deg;   //Арккотангенс

            #endregion

        }

    }
}