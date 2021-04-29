using System;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            Console.WriteLine("Please enter a shape.");
            string input = Console.ReadLine();

            IShape shape = factory.getShape(input);
            shape.draw();
        }
    }
}
