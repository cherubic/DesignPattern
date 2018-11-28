using NUnit.Framework;
using System;
using DesignPattern.VisitorPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class VisitorPatternTest
    {
        [Test()]
        public void VisitorPatternDemo()
        {
            ComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
