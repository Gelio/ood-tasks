using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.iOS
{
    class iOSTextBox : Interfaces.ITextBox
    {
        public string Content { set; get; }
        public void DrawContent()
        {
            Console.WriteLine(Content);
        }
    }
}
