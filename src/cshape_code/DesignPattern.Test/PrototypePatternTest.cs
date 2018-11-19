using NUnit.Framework;
using DesignPattern.PrototypePattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class PrototypePatternTest
    {
        [Test()]
        public void PrototypePatternDemo()
        {
            ShapeCache.LoadShape();

            Shape circle = ShapeCache.GetShape("1");
            circle.Draw();

            Shape square = ShapeCache.GetShape("2");
            square.Draw();

            Shape rectangle = ShapeCache.GetShape("3");
            rectangle.Draw();
        }
    }
}
