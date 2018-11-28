using System;
namespace DesignPattern.StrategyPattern
{
    public class OperationMultiply : Strategy
    {
        public OperationMultiply()
        {
        }

        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
