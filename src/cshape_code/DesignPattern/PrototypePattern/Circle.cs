using System;
namespace DesignPattern.PrototypePattern
{
    public class Circle : Shape
    {
        public Circle()
        {
            base.type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
