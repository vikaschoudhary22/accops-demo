using System;

namespace assignment1
{
    class Prime
    {
        static void Main()
        {
            Console.WriteLine("Prime Number Checker");

            // Prompt user for number input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is prime
            bool isPrime = CheckPrimeNumber(number);

            // Display the result
            if (isPrime)
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static bool CheckPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
