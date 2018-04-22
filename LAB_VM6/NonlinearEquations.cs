using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_VM6
{
    public static class NonlinearEquations
    {
        public delegate double NolinearFunction(double x);


        /// <summary>
        /// Уточняет значение x методом хорд, в пределах указанных границ
        /// </summary>
        /// <param name="border1">Первая граница</param>
        /// <param name="border2">Вторая граница</param>
        /// <param name="accuracy">Точность</param>
        /// <param name="f">Функция</param>
        /// <param name="itCount">Количество итераций</param>
        public static double ClarificationChords(double border1, double border2, double accuracy, NolinearFunction f, out int itCount)
        {
            bool IsEqualSign(double val1, double val2) => (val1 * val2 > 0);

            if (IsEqualSign(f(border1), f(border2))) throw new Exception("Wrong borders");

            double poolValue;
            double poolX;
            itCount = 0;

            do
            {
                poolX = border1 - f(border1) * (border2 - border1) / (f(border2) - f(border1));
                poolValue = f(poolX);

                itCount++;

                if(IsEqualSign(poolValue, f(border1)))
                {
                    border1 = poolX;
                    continue;
                }

                if (IsEqualSign(poolValue, f(border2)))
                {
                    border2 = poolX;
                    continue;
                }

                throw new Exception("Sign error");

            } while (poolValue>accuracy);

            return poolX;
        }

        /// <summary>
        /// Уточняет значение x до указанной точности
        /// </summary>
        /// <param name="originX">Исходное значение x</param>
        /// <param name="accuracy">Точность</param>
        /// <param name="f">Функция</param>
        /// <param name="itCount">Количество итераций</param>
        public static double ClarificationTangent(double originX, double accuracy, NolinearFunction f, out int itCount)
        {
            double
                lastX,
                newX = originX,
                lastAccuracy = Double.PositiveInfinity;

            itCount = 0;

            do
            {
                lastX = newX;
                newX = lastX - f(lastX) / Derivative(lastX, f);

                var currentAccuracy = Math.Abs(lastX - newX);

                if (currentAccuracy > lastAccuracy)
                    throw new Exception("The sequence diverges");

                lastAccuracy = currentAccuracy;
                itCount++;

            } while (lastAccuracy>accuracy);

            return newX;
        }

        private static double Derivative(double x, NolinearFunction f, double interval = 0.000001)
        {
            return (f(x + interval / 2) - f(x - interval / 2)) / interval;
        }
    }
}
