using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.iOS
{
    class iOSFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new iOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new iOSTextBox();
        }

        public IGrid CreateGrid()
        {
            return new iOSGrid();
        }
    }
}
