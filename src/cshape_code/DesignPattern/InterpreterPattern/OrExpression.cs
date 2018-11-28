using System;
namespace DesignPattern.InterpreterPattern
{
    public class OrExpression : Expression
    {
        private Expression expre1 = null;
        private Expression expre2 = null;

        public OrExpression(Expression expre1, Expression expre2)
        {
            this.expre1 = expre1;
            this.expre2 = expre2;
        }

        public bool Interpret(string context)
        {
            return expre1.Interpret(context) || expre2.Interpret(context);
        }
    }
}
