using System;

namespace assignment3_shape
{
    // Base class
    class Shape
    {
        // Method to calculate the area (virtual method can be overridden in derived classes)
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        // Properties
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Override CalculateArea method
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    // Derived class Circle
    class Circle : Shape
    {
        // Property
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override CalculateArea method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create objects of derived classes
            Rectangle rectangle = new Rectangle(5, 10);
            Circle circle = new Circle(7);

            // Display the areas of the shapes
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}