using System;

namespace assignment2
{
    class array
    {
        static void Main()
        {
            // Initialize an integer array with numbers
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Calculate the sum of all elements in the array
            int sum = CalculateArraySum(numbers);

            // Display the result
            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));
            Console.WriteLine($"Sum of Array Elements: {sum}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static int CalculateArraySum(int[] array)
        {
            int sum = 0;

            // Loop through each element in the array and add to the sum
            foreach (int num in array)
            {
                sum += num;
            }

            return sum;
        }
    }
}
