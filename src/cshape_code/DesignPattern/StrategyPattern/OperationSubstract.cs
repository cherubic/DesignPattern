using System;
namespace DesignPattern.StrategyPattern
{
    public class OperationSubstract : Strategy
    {
        public OperationSubstract()
        {
        }

        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
