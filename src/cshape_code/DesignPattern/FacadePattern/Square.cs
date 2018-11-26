using System;
namespace DesignPattern.FacadePattern
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
