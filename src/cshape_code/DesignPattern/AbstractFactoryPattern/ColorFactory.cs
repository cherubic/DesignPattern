using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            if (color.ToLower() == "red")
            {
                return new Red();
            }
            else if (color.ToLower() == "green")
            {
                return new Green();
            }
            else if (color.ToLower() == "blue")
            {
                return new Blue();
            }

            return null;
        }

        public override Shape GetShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
}
