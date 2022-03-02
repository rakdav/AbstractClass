using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Triangle:Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Area()
        {
            double pp = Perimetr() / 2;
            return Math.Sqrt(pp*(pp-A)*(pp-B)*(pp-C));
        }
        public override double Perimetr()
        {
            return A+B+C;
        }
        public override void Print()
        {
            Console.WriteLine($"Площадь треугольника {Area()}," +
               $" периметр:{Perimetr()}");
        }
    }
}
