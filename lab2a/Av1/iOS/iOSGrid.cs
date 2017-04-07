using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.iOS
{
    class iOSGrid : IGrid
    {
        private List<IButton> buttons = new List<IButton>();
        private List<ITextBox> textBoxes = new List<ITextBox>();

        public void AddButton(IButton button)
        {
            buttons.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textBoxes.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            return buttons;
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            return textBoxes;
        }
    }
}
