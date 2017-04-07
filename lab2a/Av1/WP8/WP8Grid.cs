using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform.WP8
{
    class WP8Grid : IGrid
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
            for (int i = textBoxes.Count - 1; i >= 0; i--)
                yield return buttons[i];
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            for (int i = 1; i < textBoxes.Count; i += 2)
                yield return textBoxes[i];
            for (int i = 0; i < textBoxes.Count; i += 2)
                yield return textBoxes[i];
        }
    }
}
