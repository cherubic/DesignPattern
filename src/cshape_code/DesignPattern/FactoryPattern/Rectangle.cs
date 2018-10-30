using System;
namespace DesignPattern.FactoryPattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public void Draw(){
            Console.WriteLine("Rectangle draw");
        }
    }
}
