using CalculateArea.Figures;
using NUnit.Framework;
using System;

namespace CalculateArea.UnitTests.Figures
{
    internal class TriangleTests
    {
        [TestCase(0, 10, 10)]
        [TestCase(10, 0, 10)]
        [TestCase(10, 10, 0)]
        [TestCase(-1, 10, 10)]
        [TestCase(10, -1, 10)]
        [TestCase(10, 10, -1)]
        public void ShouldThrowArgumentOutOfRangeExceptionWhenValidateTriangleParameters(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [TestCase(5, 5, 10)]
        [TestCase(5, 10, 5)]
        [TestCase(10, 5, 5)]
        [TestCase(10, 5, 3)]
        [TestCase(3, 5, 10)]
        [TestCase(3, 10, 5)]
        public void ShouldThrowArgumentExceptionWhenValidateTriangleParameters(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void ShouldReturnTrueWhenTriangleIsRectangular()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

        [Test]
        public void ShouldReturnFalseWhenTriangleIsNotRectangular()
        {
            Triangle triangle = new(5, 5, 2);
            Assert.IsFalse(triangle.IsRectangular());
        }

        [Test]
        public void ShouldReturnAreaWhenCalledGetArea()
        {
            Triangle triangle = new(10, 10, 5);
            Assert.AreEqual(24.206, Math.Round(triangle.GetArea(), 3));
        }
    }
}
