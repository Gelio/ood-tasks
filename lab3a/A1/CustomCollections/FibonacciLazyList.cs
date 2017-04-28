using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class FibonacciLazyList : ICustomList<double>
    {
        private List<double> values;
        private int sizeLimit;

        public int Size
        {
            get { return sizeLimit; }
        }

        public FibonacciLazyList(int sizeLimit)
        {
            this.values = new List<double>();
            this.sizeLimit = sizeLimit;
        }

        public double Get(int n)
        {
            double result = n;
            if (n > 1)
            {
                if (n < values.Count)
                {
                    result = values[n];
                }
                else
                {
                    result = Get(n - 1) + Get(n - 2);
                    values.Add(result);
                }
            }

            return result;
        }
    }
}
