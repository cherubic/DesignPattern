using System;
namespace DesignPattern.VisitorPattern
{
    public interface ComputerPart
    {
        void Accept(ComputerPartVisitor computerPartVisitor);
    }
}
