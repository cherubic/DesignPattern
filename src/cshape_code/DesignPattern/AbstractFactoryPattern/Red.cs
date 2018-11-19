using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Red : Color
    {

        public void Fill(){
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
