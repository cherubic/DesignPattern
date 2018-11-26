using NUnit.Framework;
using System;
using DesignPattern.FlyweightPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class FlyweightPatternTest
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        [Test()]
        public void FlyweightPatternDemo()
        {
            for (var i = 0; i < 20; i++)
            {
                Circle circle =
            (Circle)ShapeFactory.GetCircle(getRandomColor());
                circle.SetX(getRandomX());
                circle.SetY(getRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }
        }

        private static string getRandomColor()
        {
            return colors[(int)(new Random().Next(colors.Length))];
        }

        private static int getRandomX()
        {
            return (int)(new Random().Next(100));
        }

        private static int getRandomY()
        {
            return (int)(new Random().Next(100));
        }
    }
}
