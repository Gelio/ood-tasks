using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.WP8
{
    class WP8TextBox : Interfaces.ITextBox
    {
        private string _content;
        public string Content
        {
            set
            {
                _content = value.Substring(value.Length / 2);
            }

            get
            {
                return _content;
            }
        }
        public void DrawContent()
        {
            Console.WriteLine(Content + " by Microsoft");
        }
    }
}
