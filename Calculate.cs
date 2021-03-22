using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Calculator
    {
        // ПЕРЕГРУЗКА ОПЕРАТОРОВ
        public static double CalcTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double CalcTriangleSquare(double basis, double hight)
        {
            return 0.5 * basis * hight;
        }

        public static double CalcTriangleSquare(double a, double b, int degrees)
        {
            double angle = Math.PI * degrees / 180.0;

            double sinAngle = Math.Sin(angle);

            return 0.5 * a * b * sinAngle;
        }

        public static double Avarage(params int[] integers)
        {
            double sum = 0;

            foreach (int i in integers)
            {
                sum += i;
            }

            return sum / integers.Length;
        }

    }


}
