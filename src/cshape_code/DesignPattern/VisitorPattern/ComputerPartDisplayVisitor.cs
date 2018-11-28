using System;
namespace DesignPattern.VisitorPattern
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {
        public ComputerPartDisplayVisitor()
        {
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Display Computer");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Display Mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Display Keyboard");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Display Monitor");
        }
    }
}
