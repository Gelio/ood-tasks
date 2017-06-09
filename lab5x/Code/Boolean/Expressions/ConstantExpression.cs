using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Boolean;

namespace Parser.Boolean.Expressions
{
    class ConstantExpression : IBooleanExpression
    {
        private bool _constant;

        public ConstantExpression(bool value)
        {
            _constant = value;
        }

        public bool Evaluate(BooleanContext context)
        {
            return _constant;
        }

        public override string ToString()
        {
            return _constant ? "true" : "false";
        }
    }
}
