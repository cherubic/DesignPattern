using System;
namespace DesignPattern.PrototypePattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            base.type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
