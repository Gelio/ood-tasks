using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.WP8
{
    class WP8Button : Interfaces.IButton
    {
        private string _content;

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value.ToUpper();
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(Content);
        }

        public void ButtonPressed()
        {
            Console.WriteLine("WP8 Button pressed, content: " + Content);
        }
    }
}
