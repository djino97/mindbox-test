using CalculateArea.Interfaces;
using Moq;
using NUnit.Framework;

namespace CalculateArea.UnitTests
{
    [TestFixture]
    internal class CalculationFigureAreaTests
    {
        [Test]
        public void ShouldGetAreaFigure()
        {
            int expectedArea = 20;
            var figureMock = new Mock<Figure>();
            figureMock
                .Setup(f => f.GetArea())
                .Returns(expectedArea);
            ICalculationFigureArea calculationFigureArea =
                new CalculationFigureArea();

            Assert.AreEqual(expectedArea, calculationFigureArea.GetArea(figureMock.Object));
            figureMock.Verify(x => x.GetArea(), Times.Once);
        }
    }
}
