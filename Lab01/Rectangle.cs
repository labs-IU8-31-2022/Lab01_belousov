namespace Lab01;

public class Rectangle
{
    private double _side1, _side2;
    public Rectangle(double sideA, double sideB)
    {
        _side1 = Math.Abs(sideA);
        _side2 = Math.Abs(sideB);
    }

    private double AreaCalculator() => _side1 * _side2;
    private double PerimeterCalculator() => 2 * (_side1 + _side2);

    public double Area => AreaCalculator();

    public double Perimeter => PerimeterCalculator();
}
