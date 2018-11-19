using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Green : Color
    {
        public Green()
        {
        }

        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
