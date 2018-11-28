using System;
namespace DesignPattern.VisitorPattern
{
    public class Monitor : ComputerPart
    {
        public Monitor()
        {
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
