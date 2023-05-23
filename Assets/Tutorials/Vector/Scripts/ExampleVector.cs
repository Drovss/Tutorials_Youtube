using UnityEngine;

namespace Tutorials.Vector.Scripts
{
    public class ExampleVector : MonoBehaviour
    {
        private void Start()
        {
            var vector = new Vector3(3, 4, 0);
            
            var newVector = new Vector3(2, 4, 0);
            
            #region Components1
            
            var x = vector.x;
            var y = vector.y;
            var z = vector.z;

            #endregion
            
            #region Components2

            var x2 = vector[0];
            var y2 = vector[1];
            var z2 = vector[2];

            #endregion

            //нормалізація
            #region Normalized

            var normVector = vector.normalized; // (0.60, 0.80, 0.00)
            
            #endregion 

            // довижина вектора
            #region Magnitude

            var len = vector.magnitude; // 5

            #endregion
            
            // квадрат довжини вектора
            #region Magnitude

            var sqrLen = vector.sqrMagnitude; // 25

            #endregion 

            //перемноження компонентів двох векторів
            #region Scale

            var scale = Vector3.Scale(vector, newVector); // (6.00, 16.00, 0.00)

            #endregion

            //Перехресний добуток векторів
            #region Cross

            var cross = Vector3.Cross(vector, newVector); // (0.00, 0.00, 4.00)

            #endregion

            //Скалярний добуток
            #region Dot

            var dot = Vector3.Dot(vector, newVector); // 22

            #endregion

            // Віддзеркалення вектора
            #region Reflect

            var reflect = Vector3.Reflect(vector, Vector3.right); //(-3.00, 4.00, 0.00)

            #endregion

            // Дистанція між векторами
            #region Distance

            var distance = Vector3.Distance(vector, newVector); // 1

            #endregion
            
            // Кут між векторами
            #region Angle

            var angle = Vector3.Angle(vector, newVector); // 10.30485

            #endregion
            
            // Проекція на вектора на вектор
            #region Project

            var project = Vector3.Project(vector, newVector); // (2.20, 4.40, 0.00)

            #endregion
            
            
        }
    }
}