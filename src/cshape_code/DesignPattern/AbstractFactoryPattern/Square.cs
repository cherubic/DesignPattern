using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
