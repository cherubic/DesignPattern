using System;
namespace DesignPattern.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            throw new NotImplementedException();
        }

        public override Shape GetShape(string shape)
        {
            if (shape.ToLower() == "rectangle")
            {
                return new Rectangle();
            }
            else if (shape.ToLower() == "square")
            {
                return new Square();
            }
            else if (shape.ToLower() == "circle")
            {
                return new Circle();
            }

            return null;
        }
    }
}
