using NUnit.Framework;
using System;
using DesignPattern.FacadePattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class FacadePatternTest
    {
        [Test()]
        public void FacadePatternDemo()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
