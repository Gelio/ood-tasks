using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.CustomCollections
{
    class ArrayList2DCR : ArrayList2D, ICustomList<double>
    {
        public ArrayList2DCR(double[,] matrix) : base(matrix) { }

        public override double Get(int n)
        {
            int row = n % ColumnSize;
            int column = n / ColumnSize;
            return base.Get(row, column);
        }
    }
}