using System;

namespace assignment2
{
    class reverse
    {
        static void Main()
        {
            Console.WriteLine("String Reversal Program");

            // Prompt user for string input
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            // Reverse the string
            string reversedString = ReverseString(inputString);

            // Display the result
            Console.WriteLine($"Reversed String: {reversedString}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);
            string reverse_ = "";
            int size_ = charArray.Length;
            for(int i = size_ - 1; i>=0; i--)
            {
                reverse_ += charArray[i];
            }
            return reverse_;
        }
    }
}
