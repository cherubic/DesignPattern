using NUnit.Framework;
using System;
using DesignPattern.TemplatePattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class TemplatePatternTest
    {
        [Test()]
        public void TestCase()
        {
            Game game = new Cricket();
            game.Play();
            game = new Football();
            game.Play();
        }
    }
}
