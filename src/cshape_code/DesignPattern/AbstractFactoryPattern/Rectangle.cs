using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
