using NUnit.Framework;
using System;
using DesignPattern.DecoratorPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class DecoratorPatternTest
    {
        [Test()]
        public void DecoratorPatternDemo()
        {
            Shape circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
        }
    }
}
