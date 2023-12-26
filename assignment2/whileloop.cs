using System;

namespace assignment2
{
    class whileloop
    {
        static void Main()
        {
            Console.WriteLine("Sum of Even Numbers from 1 to 100:");

            int sum = 0;
            int number = 2; // Start with the first even number

            // Using a while loop to find the sum of even numbers from 1 to 100
            while (number <= 100)
            {
                sum += number;
                number += 2; // Move to the next even number
            }

            // Display the result
            Console.WriteLine($"The sum of even numbers from 1 to 100 is: {sum}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}