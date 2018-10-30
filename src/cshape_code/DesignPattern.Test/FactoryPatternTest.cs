using NUnit.Framework;
using DesignPattern.FactoryPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class FactoryPatternTest
    {
        [Test()]
        public void FactoryDemo()
        {
            var shapeFactory = new ShapeFactory();

            var shape1 = shapeFactory.GetShape("Circle");
            shape1.Draw();

            var shape2 = shapeFactory.GetShape("Rectangle");
            shape2.Draw();

            var shape3 = shapeFactory.GetShape("Square");
            shape3.Draw();
        }
    }
}
