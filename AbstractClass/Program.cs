using AbstractClass;

namespace MyApp
{
    public class AbstartClass
    {
        public static void Main(string[] args)
        {
            Rectangle rect=new Rectangle(4,9);
            rect.Print();
            Triangle triangle = new Triangle(3,4,5);
            triangle.Print();
            Circle circle = new Circle(10);
            circle.Print();
        }
    }
}