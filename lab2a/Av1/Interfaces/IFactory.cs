using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Interfaces
{
    interface IFactory
    {
        ITextBox CreateTextBox();
        IButton CreateButton();
        IGrid CreateGrid();
    }
}
