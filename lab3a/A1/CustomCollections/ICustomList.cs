using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    public interface ICustomList<T>
    {
        int Size { get; }
        double Get(int n);
    }
}
