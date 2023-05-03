namespace CalculateArea.Interfaces
{
    /// <summary>
    /// It's the library call point for calculating the area of any figure.
    /// </summary>
    public interface ICalculationFigureArea
    {
        double GetArea(Figure figure);
    }
}
