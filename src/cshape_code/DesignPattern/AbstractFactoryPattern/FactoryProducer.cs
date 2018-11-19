using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.ToLower() == "shape")
            {
                return new ShapeFactory();
            }
            else if (choice.ToLower() == "color")
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
