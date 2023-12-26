using System;

namespace assignment1
{
    class evenodd
    {
        static void Main()
        {
            Console.WriteLine("Even or Odd Checker");

            // Prompt user for number input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is even or odd
            string result = CheckEvenOrOdd(number);

            // Display the result
            Console.WriteLine($"{number} is {result}.");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static string CheckEvenOrOdd(int number)
        {
            return (number % 2 == 0) ? "even" : "odd";
        }
    }
}
