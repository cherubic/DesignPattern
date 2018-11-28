using System;
namespace DesignPattern.VisitorPattern
{
    public class Mouse : ComputerPart
    {
        public Mouse()
        {
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
