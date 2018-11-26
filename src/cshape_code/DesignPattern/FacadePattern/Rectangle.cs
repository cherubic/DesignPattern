using System;
namespace DesignPattern.FacadePattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public void Draw(){
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
