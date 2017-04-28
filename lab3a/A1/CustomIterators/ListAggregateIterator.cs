using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class ListAggregateIterator : IEnumerable<double>
    {
        private ICustomList<double> _list = null;

        public ListAggregateIterator(ICustomList<double> list)
        {
            _list = list;
        }

        public IEnumerator<double> GetEnumerator()
        {
            double sum = 0;
            for (int i = 0; i < _list.Size; i++)
            {
                sum += _list.Get(i);
                yield return sum;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
