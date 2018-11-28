using System;
namespace DesignPattern.VisitorPattern
{
    public class Computer : ComputerPart
    {
        ComputerPart[] parts;

        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            foreach(var computerpart in parts){
                computerpart.Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}
