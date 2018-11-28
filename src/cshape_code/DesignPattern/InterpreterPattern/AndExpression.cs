using System;
namespace DesignPattern.InterpreterPattern
{
    public class AndExpression : Expression
    {
        private Expression expre1;
        private Expression expre2;

        public AndExpression(Expression expre1, Expression expre2)
        {
            this.expre1 = expre1;
            this.expre2 = expre2;
        }

        public bool Interpret(string context)
        {
            return expre1.Interpret(context) && expre2.Interpret(context);
        }
    }
}
