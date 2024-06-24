using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     * Example of abstraction using abstract class
     */
    internal class Q23
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle { Width = 5, Height = 3 };
            Circle circle = new Circle { Radius = 4 };

            Console.WriteLine($"Area of rectangle: {rect.Area()}"); // Output: Area of rectangle: 15
            Console.WriteLine($"Area of circle: {circle.Area()}");   // Output: Area of circle: 50.26548245743669
        }
    }


    // Example of abstraction in C#
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
