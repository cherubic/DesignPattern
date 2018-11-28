using NUnit.Framework;
using System;
using DesignPattern.StatePattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class StatePatternTest
    {
        [Test()]
        public void StatePatternDemo()
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());
        }
    }
}
