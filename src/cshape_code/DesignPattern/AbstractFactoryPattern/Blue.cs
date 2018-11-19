using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class Blue : Color
    {
        public Blue()
        {
        }

        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
