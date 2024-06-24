using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     * Example of abstraction using interface
     */
    // Define an interface for shapes
    public interface IShape
    {
        double Area(); // Interface method for calculating area, to be implemented by concrete classes
    }

    // Concrete class Rectangle implementing the IShape interface
    public class Rectangle2 : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }

    // Concrete class Circle implementing the IShape interface
    public class Circle2 : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create instances of Rectangle and Circle
            Rectangle2 rectangle = new Rectangle2 { Width = 5, Height = 3 };
            Circle2 circle = new Circle2 { Radius = 4 };

            // Use the Area() method through the IShape interface
            Console.WriteLine($"Area of rectangle: {rectangle.Area()}"); // Output: Area of rectangle: 15
            Console.WriteLine($"Area of circle: {circle.Area()}");       // Output: Area of circle: 50.26548245743669
        }
    }
}
