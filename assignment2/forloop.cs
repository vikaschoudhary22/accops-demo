using System;

namespace assignment2
{
    class forloop
    {
        static void Main()
        {
            Console.WriteLine("First 10 Natural Numbers:");

            // Using a for loop to print the first 10 natural numbers
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
