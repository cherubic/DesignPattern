using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Color GetColor(string color);
        public abstract Shape GetShape(string shape);
    }
}
