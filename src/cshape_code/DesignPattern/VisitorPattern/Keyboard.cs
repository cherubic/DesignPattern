using System;
namespace DesignPattern.VisitorPattern
{
    public class Keyboard : ComputerPart
    {
        public Keyboard()
        {
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
