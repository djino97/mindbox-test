using CalculateArea.Interfaces;

namespace CalculateArea
{
    /// <inheritdoc cref="ICalculationFigureArea"/>
    public class CalculationFigureArea : ICalculationFigureArea
    {
        public double GetArea(Figure figure)
        {
            return figure.GetArea();
        }
    }
}
