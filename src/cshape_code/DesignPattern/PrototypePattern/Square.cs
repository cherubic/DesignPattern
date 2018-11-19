using System;
namespace DesignPattern.PrototypePattern
{
    public class Square : Shape
    {
        public Square()
        {
            base.type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
