using System;
namespace DesignPattern.DecoratorPattern
{
	public class Circle : Shape
    {
        public Circle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
