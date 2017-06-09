using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Boolean;

namespace Parser.Boolean.Expressions
{
    class NotExpression : IBooleanExpression
    {
        private IBooleanExpression _baseExpression;

        public NotExpression(IBooleanExpression baseExpression)
        {
            _baseExpression = baseExpression;
        }

        public bool Evaluate(BooleanContext context)
        {
            return !_baseExpression.Evaluate(context);
        }

        public override string ToString()
        {
            return $"!({_baseExpression})";
        }
    }
}
