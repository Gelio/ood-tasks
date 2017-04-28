using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.CustomCollections
{
    class ArrayList2DRC : ArrayList2D, ICustomList<double>
    {

        public ArrayList2DRC(double[,] matrix) : base(matrix) { }

        public override double Get(int n)
        {
            int row = n / RowSize;
            int column = n % RowSize;
            return base.Get(row, column);
        }
    }
}
