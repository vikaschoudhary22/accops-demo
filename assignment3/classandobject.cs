using System;

namespace assignment3
{
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class classandobject
    {
        static void Main()
        {
            // Create an object of the Person class
            Person person = new Person("John Doe", 25);

            // Display the person's information
            Console.WriteLine("Person's Information:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age} years");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }

}