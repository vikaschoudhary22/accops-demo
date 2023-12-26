using System;

namespace assignment3
{
    // Base class
    class Animal
    {
        // Method to make a sound (virtual method can be overridden in derived classes)
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }

    // Derived class Bird
    class Bird : Animal
    {
        // Override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Chirp! Chirp!");
        }
    }

    class animal
    {
        static void Main()
        {
            // Create objects of derived classes
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal bird = new Bird();

            // Call the MakeSound method for each object
            Console.WriteLine("Dog sounds:");
            dog.MakeSound();

            Console.WriteLine("\nCat sounds:");
            cat.MakeSound();

            Console.WriteLine("\nBird sounds:");
            bird.MakeSound();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}