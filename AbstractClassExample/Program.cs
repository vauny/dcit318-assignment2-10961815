// See https://aka.ms/new-console-template for more information

using System;

namespace AbstractClassExample
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(6);
            Console.WriteLine($"Circle area: {circle.GetArea()}");

            Rectangle rectangle = new Rectangle(5, 7);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        }
    }
}
