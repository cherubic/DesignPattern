using System;
namespace DesignPattern.DecoratorPattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
