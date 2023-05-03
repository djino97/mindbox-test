using CalculateArea.Interfaces;
using System;

namespace CalculateArea.Figures
{
    public sealed class Circle : Figure
    {
        public readonly double Radius;

        private void ValidateCircleParameters(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));
        }

        public Circle(double radius)
        {
            ValidateCircleParameters(radius);

            Radius = radius;
        }

        public sealed override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
