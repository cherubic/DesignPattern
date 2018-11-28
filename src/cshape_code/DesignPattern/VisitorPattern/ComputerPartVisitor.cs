using System;
namespace DesignPattern.VisitorPattern
{
    public interface ComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
