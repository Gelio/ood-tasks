using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.iOS
{
    class iOSButton : Interfaces.IButton
    {
        public string Content
        {
            set; get;
        }

        public void DrawContent()
        {
            Console.WriteLine(Content);
        }

        public void ButtonPressed()
        {
            Console.WriteLine("IOS Button pressed, content: " + Content);
        }
    }
}
