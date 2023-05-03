using CalculateArea.Figures;
using NUnit.Framework;
using System;

namespace CalculateArea.UnitTests.Figures
{
    [TestFixture]
    internal class CircleTests
    {
        [TestCase(0)]
        [TestCase(-1)]
        public void ShouldThrowExceptionWhenValidateCircleParameters(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Test]
        public void ShouldReturnAreaWhenCalledGetArea()
        {
            Circle circle = new(5);
            Assert.AreEqual(78.54, Math.Round(circle.GetArea(), 3));
        }
    }
}
