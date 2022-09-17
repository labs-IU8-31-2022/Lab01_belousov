namespace Lab01.Tests;

[TestClass]
public class Tests
{
    [DataTestMethod]
    [DataRow(4, 5)]
    public void FieldsOfPoint(double x, double y)
    {
        Point p = new Point(x, y);
        Assert.AreEqual(4, p.x);
        Assert.AreEqual(5, p.y);
    }
    
    [DataTestMethod]
    [DataRow(12, 12, 144)]
    [DataRow(5, 6, 30)]
    public void AreaCalculating(double side1, double side2, double expected)
    {
        Rectangle current = new Rectangle(side1, side2);
        double result = current.Area;
        Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [DataRow(12, 12, 48)]
    [DataRow(5, 6, 22)]
    public void PerimeterCelculating(double side1, double side2, double expected)
    {
        Rectangle current = new Rectangle(side1, side2);
        double result = current.Perimeter;
        Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [DataRow(5, 6, 8, 10, 5)]
    public void LengthCalculating(double x1, double y1, double x2, double y2, double expected)
    {
        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);
        Figure current = new Figure(p1, p2);
        double result = current.LengthSide(p1, p2);
        Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [DataRow(5, 6, 8, 10, 10, 12, 15)]
    public void Perimeter_3p(double x1, double y1, double x2, double y2, double x3, double y3, double expected)
    {
        Figure current = new Figure(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3));
        int result = (int)current.PerimeterCalculator();
        Assert.AreEqual(result, expected);
    }

    [DataTestMethod]
    [DataRow(5, 6, 8, 10, 10, 12, "Triangle")]
    public void Name_3p(double x1, double y1, double x2, double y2, double x3, double y3, string expected)
    {
        Figure current = new Figure(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3));
        string result = current.name_of_figure;
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [DataRow(5, 6, 8, 10)]
    [ExpectedException(typeof(Exception))]
    public void Exception(double x1, double y1, double x2, double y2)
    {
        Figure current = new Figure(new Point(x1, y1), new Point(x2, y2));
        double perimeter = current.PerimeterCalculator();
    }
}
