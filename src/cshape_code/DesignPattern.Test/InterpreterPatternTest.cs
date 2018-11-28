using NUnit.Framework;
using System;
using DesignPattern.InterpreterPattern;

namespace DesignPattern.Test
{
    [TestFixture()]
    public class InterpreterPatternTest
    {
        [Test()]
        public void InterpreterPatternDemo()
        {
            Expression isMale = getMaleExpression();
            Expression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is a married women? "
            + isMarriedWoman.Interpret("Married Julie"));
        }

        private Expression getMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        private Expression getMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
    }
}
