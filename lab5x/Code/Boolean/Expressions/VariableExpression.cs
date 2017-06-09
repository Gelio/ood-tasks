using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Boolean;

namespace Parser.Boolean.Expressions
{
    class VariableExpression : IBooleanExpression
    {
        private string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public bool Evaluate(BooleanContext context)
        {
            return context.GetVariable(_name);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
