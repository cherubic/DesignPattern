using NUnit.Framework;
using DesignPattern.AbstractFactoryPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class AbstractFactoryPatternTest
    {
        [Test()]
        public void AbstractFactoryPatternDemo()
        {
            AbstractFactory abstractFactory = FactoryProducer.GetFactory("shape");
            var shape1 = abstractFactory.GetShape("circle");
            shape1.Draw();

            var shape2 = abstractFactory.GetShape("rectangle");
            shape2.Draw();

            var shape3 = abstractFactory.GetShape("square");
            shape3.Draw();

            abstractFactory = FactoryProducer.GetFactory("color");

            var color1 = abstractFactory.GetColor("red");
            color1.Fill();

            var color2 = abstractFactory.GetColor("green");
            color2.Fill();

            var color3 = abstractFactory.GetColor("blue");
            color3.Fill();
        }
    }
}
