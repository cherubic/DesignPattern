using System;
namespace DesignPattern.InterpreterPattern
{
    public interface Expression
    {
        bool Interpret(string context);
    }
}
