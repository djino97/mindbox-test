using CalculateArea.Interfaces;
using System;

namespace CalculateArea.Figures
{
    public sealed class Triangle : Figure
    {
        // Three sides of a triangle.
        public readonly double A;
        public readonly double B;
        public readonly double C;

        private void ValidateTriangleParameters(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a));
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b));
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c));

            if (a + b <= c || a + c <= b || c + b <= a)
                throw new ArgumentException(
                    "The sum of the lengths of two sides of a triangle must be greater than the third side.");
        }

        public Triangle(double a, double b, double c)
        {
            ValidateTriangleParameters(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public bool IsRectangular()
        {
            Func<double, double, bool> checkTriangle = (sidesSum, c)
                => Math.Round(sidesSum, 1) - Math.Round(c, 1) <= 0;

            double a = Math.Pow(A, 2);
            double b = Math.Pow(B, 2);
            double c = Math.Pow(C, 2);

            return checkTriangle(a + b, c)
                   || checkTriangle(a + c, b)
                   || checkTriangle(b + c, a);
        }

        public sealed override double GetArea()
        {
            double semiperimeter = (A + B + C) / 2;
            return Math.Sqrt(semiperimeter
                             * (semiperimeter - A)
                             * (semiperimeter - B)
                             * (semiperimeter - C));
        }
    }
}
