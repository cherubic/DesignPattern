using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
