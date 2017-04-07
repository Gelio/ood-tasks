using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Android
{
    class AndroidTextBox : Interfaces.ITextBox
    {
        private string _content;
        public string Content
        {
            set
            {
                _content = value;
                _content.Reverse();
            }

            get
            {
                return _content;
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(Content);
        }
    }
}
