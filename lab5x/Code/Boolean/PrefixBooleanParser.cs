using Boolean.Boolean;
using OOD_5A1.Boolean.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Parser.Boolean.Expressions;

namespace OOD_5A1.Boolean
{
    class PrefixBooleanParser
    {
        private string _prefixExpression;
        private int _currentIndex;

        public IBooleanExpression Parse(string prefix_expression)
        {
            _prefixExpression = prefix_expression;
            _currentIndex = 0;
            IBooleanExpression parsedExpression = InternalParse();

            if (_currentIndex < _prefixExpression.Length)
                throw new SyntaxErrorException();

            return parsedExpression;
        }

        private IBooleanExpression InternalParse()
        {
            string mainExpressionString = GetNextExpressionString();
            switch (mainExpressionString)
            {
                case "1":
                    return new ConstantExpression(true);

                case "0":
                    return new ConstantExpression(false);

                case "AND":
                    {
                        IBooleanExpression left = InternalParse();
                        IBooleanExpression right = InternalParse();
                        return new AndExpression(left, right);
                    }

                case "NOT":
                    IBooleanExpression expression = InternalParse();
                    return new NotExpression(expression);

                case "OR":
                    {
                        IBooleanExpression left = InternalParse();
                        IBooleanExpression right = InternalParse();
                        return new OrExpression(left, right);
                    }

                default:
                    if (mainExpressionString.Length == 0)
                        throw new SyntaxErrorException();
                    return new VariableExpression(mainExpressionString);
            }
        }

        private string GetNextExpressionString()
        {
            if (_currentIndex >= _prefixExpression.Length)
                throw new SyntaxErrorException();

            int firstSpaceIndex = _prefixExpression.IndexOf(' ', _currentIndex);
            if (firstSpaceIndex == -1)
                firstSpaceIndex = _prefixExpression.Length;

            string mainExpressionString = _prefixExpression.Substring(_currentIndex, firstSpaceIndex - _currentIndex);
            _currentIndex = firstSpaceIndex + 1;
            return mainExpressionString;
        }
    }
}
