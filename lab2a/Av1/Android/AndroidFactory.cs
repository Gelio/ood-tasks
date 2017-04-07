using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.Android
{
    class AndroidFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new AndroidButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AndroidTextBox();
        }

        public IGrid CreateGrid()
        {
            return new AndroidGrid();
        }
    }
}
