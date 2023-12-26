using System;

namespace assignment3
{
    // Interface for drawable objects
    public interface IDrawable
    {
        void Draw();
    }

    // Circle class implementing IDrawable
    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Square class implementing IDrawable
    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }

    class IDraw
    {
        static void Main()
        {
            // Create an array of IDrawable objects
            IDrawable[] drawableObjects = new IDrawable[]
            {
            new Circle(),
            new Square(),
            new Circle(),
            new Square()
            };

            // Call the Draw method for each object in the array
            foreach (IDrawable drawableObject in drawableObjects)
            {
                drawableObject.Draw();
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}