using MindBoxTask.lib;

namespace MindBoxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            
            double circle = calculator.Calc(new Circle(25.0));
            Console.WriteLine($"Площадь круга = { circle }");

            double triangle = calculator.Calc(new Triangle(5, 5, 5));
            Console.WriteLine($"Площадь треугольника = {triangle}");
        }
    }
}