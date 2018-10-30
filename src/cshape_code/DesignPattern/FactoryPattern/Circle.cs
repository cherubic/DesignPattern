using System;
namespace DesignPattern.FactoryPattern
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public void Draw(){
            Console.WriteLine("Circle draw");
        }
    }
}
