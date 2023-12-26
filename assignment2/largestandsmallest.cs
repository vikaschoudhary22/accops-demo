using System;

namespace assignment2
{
    class largestandsmallest
    {
        static void Main()
        {
            // Initialize an integer array with numbers
            int[] numbers = { 15, 7, 23, 10, 35, 42, 5 };

            // Find the largest and smallest numbers in the array
            int largest = FindLargestNumber(numbers);
            int smallest = FindSmallestNumber(numbers);

            // Display the result
            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));
            Console.WriteLine($"Largest Number: {largest}");
            Console.WriteLine($"Smallest Number: {smallest}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static int FindLargestNumber(int[] array)
        {
            int largest = array[0];

            // Loop through each element in the array to find the largest number
            foreach (int num in array)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        static int FindSmallestNumber(int[] array)
        {
            int smallest = array[0];

            // Loop through each element in the array to find the smallest number
            foreach (int num in array)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            return smallest;
        }
    }
}
