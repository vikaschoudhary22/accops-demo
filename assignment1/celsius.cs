using System;

namespace assignment1
{
    class Celsius
    {
        static void Main()
        {
            Console.WriteLine("Celsius to Fahrenheit Converter");

            // Prompt user for temperature in Celsius
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit
            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

            // Display the result
            Console.WriteLine($"{celsius} degrees Celsius is equivalent to {fahrenheit} degrees Fahrenheit.");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
