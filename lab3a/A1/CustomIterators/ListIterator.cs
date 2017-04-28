using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A1
{
    class ListIterator : IEnumerable<double>
    {
        private ICustomList<double> _list = null;

        public ListIterator(ICustomList<double> list)
        {
            _list = list;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 0; i < _list.Size; i++)
                yield return _list.Get(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
