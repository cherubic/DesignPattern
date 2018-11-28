using NUnit.Framework;
using System;
using DesignPattern.StrategyPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class StrategyPatternTest
    {
        [Test()]
        public void StrategyPatternDemo()
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
