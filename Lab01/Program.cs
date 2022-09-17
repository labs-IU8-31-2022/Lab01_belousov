// Belousov, IU8-31
using Lab01;

class Program
{
    static void Main(string[] args)
    {
        //TASK1
        {
            Console.WriteLine("Min value of bool: 0");
            Console.WriteLine("Max value of bool: 1");
            Console.WriteLine($"Min value of byte: {byte.MinValue}");
            Console.WriteLine($"Max value of byte: {byte.MaxValue}");
            Console.WriteLine($"Min value of sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Max value of sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Min value of short: {short.MinValue}");
            Console.WriteLine($"Max value of short: {short.MaxValue}");
            Console.WriteLine($"Min value of int: {int.MinValue}");
            Console.WriteLine($"Max value of int: {int.MaxValue}");
            Console.WriteLine($"Min value of long: {long.MinValue}");
            Console.WriteLine($"Max value of long: {long.MaxValue}");
            Console.WriteLine($"Min value of ushort: {ushort.MinValue}");
            Console.WriteLine($"Max value of ushort: {ushort.MaxValue}");
            Console.WriteLine($"Min value of uint: {uint.MinValue}");
            Console.WriteLine($"Max value of uint: {uint.MaxValue}");
            Console.WriteLine($"Min value of ulong: {ulong.MinValue}");
            Console.WriteLine($"Max value of ulong: {ulong.MaxValue}");
            Console.WriteLine($"Min value of float: {float.MinValue}");
            Console.WriteLine($"Max value of float: {float.MaxValue}");
            Console.WriteLine($"Min value of double: {double.MinValue}");
            Console.WriteLine($"Max value of double: {double.MaxValue}");
            Console.WriteLine($"Min value of char: {char.MinValue}");
            Console.WriteLine($"Max value of char: {char.MaxValue}");
            Console.WriteLine($"Min value of decimal: {decimal.MinValue}");
            Console.WriteLine($"Max value of decimal: {decimal.MaxValue}");   
        }
        Console.WriteLine("=============================");
        {
            //TASK 2
            Console.WriteLine("Please insert sides of rectangle");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle a1 = new Rectangle(side1, side2);
            Console.WriteLine($"Area: {a1.Area}");
            Console.WriteLine($"Perimeter: {a1.Perimeter}");
        }
        Console.WriteLine("=============================");
        {
            //TASK 3
            Point p1 = new Point(5, 6);
            Point p2 = new Point(8, 10);
            Point p3 = new Point(10, 12);
            Figure f = new Figure(p1, p2, p3);
            f.LengthSide(p1, p2);
            try
            {
                Console.WriteLine($"Name of figure: {f.name_of_figure}");
                Console.WriteLine($"Length of side p1-p2: {f.LengthSide(p1, p2)}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            } 

            Console.WriteLine($"Name of figure: {f.name_of_figure}");
            Console.WriteLine($"Length of side p1-p2: {f.LengthSide(p1, p2)}");
            Console.WriteLine($"Length of side p2-p3: {f.LengthSide(p2, p3)}");
            Console.WriteLine($"Length of side p3-p1: {f.LengthSide(p3, p1)}");
            Console.WriteLine($"Perimeter: {f.PerimeterCalculator()}");
        } 
    }
}
