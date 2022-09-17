namespace Lab01;

public class Figure
{
    private List<Point>? points_of_figure;
    public Figure(params Point[] args)
    {
        points_of_figure = new List<Point>();
        foreach (Point p in args)
        {
            points_of_figure.Add(p);
        }
    }

    public string name_of_figure
    {
        get
        {
            if (points_of_figure.Count < 3)
            {
                throw new Exception("It isn't figure");
            }else if (points_of_figure.Count == 3)
            {
                return "Triangle";
            }
            else if (points_of_figure.Count == 4)
            {
                return "Rectangle";
            }
            else if (points_of_figure.Count == 5)
            {
                return "Pentagon";
            }
            else
            {
                return "Undefined";
            }
        }
    }
    public double LengthSide(Point A, Point B) => Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));

    public double PerimeterCalculator()
    {
        if (points_of_figure.Count < 3)
        {
            throw new Exception("It isn't figure");
        }

        double sum = 0;
        for (int i = 0; i < points_of_figure.Count; ++i)
        {
            if (i == points_of_figure.Count - 1)
            {
                sum += LengthSide(points_of_figure[i], points_of_figure[0]);
                break;
            }
            sum += LengthSide(points_of_figure[i], points_of_figure[i + 1]);
        }

        return sum;
    }
}
