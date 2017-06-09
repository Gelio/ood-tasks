using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Boolean;

namespace Parser.Boolean.Expressions
{
    class AndExpression : IBooleanExpression
    {
        private IBooleanExpression _left;
        private IBooleanExpression _right;

        public AndExpression(IBooleanExpression left, IBooleanExpression right)
        {
            _left = left;
            _right = right;
        }

        public bool Evaluate(BooleanContext context)
        {
            return _left.Evaluate(context) && _right.Evaluate(context);
        }

        public override string ToString()
        {
            return $"({_left} AND {_right})";
        }
    }
}
