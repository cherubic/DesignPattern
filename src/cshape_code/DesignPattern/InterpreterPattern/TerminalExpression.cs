﻿using System;
namespace DesignPattern.InterpreterPattern
{
    public class TerminalExpression : Expression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
