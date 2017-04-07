using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.WP8
{
    class WP8Factory : IFactory
    {
        public IButton CreateButton()
        {
            return new WP8Button();
        }

        public ITextBox CreateTextBox()
        {
            return new WP8TextBox();
        }

        public IGrid CreateGrid()
        {
            return new WP8Grid();
        }
    }
}
