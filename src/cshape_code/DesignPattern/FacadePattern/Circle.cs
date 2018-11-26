using System;
namespace DesignPattern.FacadePattern
{
	public class Circle : Shape
    {
        public Circle()
        {
        }

        public void Draw(){
            Console.WriteLine("Circle::draw()");
        }
    }
}
