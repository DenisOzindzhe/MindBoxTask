using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTask.lib
{
    internal class Calculate
    {
        public double Calc(ICalculate calculate)
        {
            return calculate.Calculate();
        }

    }

    //Фигуры
    public class Triangle:ICalculate
    {

        public double ab { get; set; }
        public double bc { get; set; }
        public double ac { get; set; }

        public Triangle(double ab, double bc, double ac) 
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException("Неверно введены значения");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException($"Неверно введены значения");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }
        //По трем сторонам. Формула Герона.
        public double Calculate()
        {
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }
        public bool IsRectangular()
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2))
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check;
        }


    }
    public class Circle : ICalculate
    {
        public double Radius { get; set; }

        public Circle(double value)
        {
            Radius = value;
        }
        public double Calculate()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }


}
