using NUnit.Framework;
using System;
using DesignPattern.Bridge;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class BridgePatternTest
    {
        [Test()]
        public void BridgePatternDemo()
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
