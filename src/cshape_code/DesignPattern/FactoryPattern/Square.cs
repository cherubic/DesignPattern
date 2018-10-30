using System;
namespace DesignPattern.FactoryPattern
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public void Draw(){
            Console.WriteLine("Square draw");
        }
    }
}
