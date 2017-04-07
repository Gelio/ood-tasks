using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Android
{
    class AndroidButton : Interfaces.IButton
    {
        private string _content;
        public string Content
        {
            set
            {
                _content = value.Replace('o', 'a')
                    .Replace('e', 'a')
                    .Replace('i', 'a')
                    .Replace('u', 'a')
                    .Replace('y', 'a');
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

        public void ButtonPressed()
        {
            Console.WriteLine("Android is the best platform " + Content);
        }
    }
}
