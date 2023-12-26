using System;

namespace assignment1
{
    class area
    {
        static void Main()
        {
            Console.WriteLine("Rectangle Area Calculator");

            // Prompt user for length input
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Prompt user for width input
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            double area = CalculateRectangleArea(length, width);

            // Display the result
            Console.WriteLine($"The area of the rectangle is: {area}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}