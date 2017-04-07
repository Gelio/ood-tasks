using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Interfaces;

namespace MultiPlatform
{
	class Program
	{
		static void Main(string[] args)
		{
            IFactory factory = null;

            Console.WriteLine("<---------------------FIRST PLATFORM--------------------->");
            Console.WriteLine("(Android)");
            factory = new Android.AndroidFactory();
            BuildInterface(factory);
			

			Console.WriteLine("<---------------------SECOND PLATFORM--------------------->");
            Console.WriteLine("(iOS)");
            factory = new iOS.iOSFactory();
            BuildInterface(factory);


            Console.WriteLine("<---------------------THIRD PLATFORM--------------------->");
            Console.WriteLine("(WP8)");
            factory = new WP8.WP8Factory();
            BuildInterface(factory);

        }

        static void BuildInterface(IFactory factory)
        {
            int buttonsCount = 3,
                textBoxesCount = 3;

            IGrid grid = factory.CreateGrid();
            for (int i=0; i < buttonsCount; i++)
            {
                IButton button = factory.CreateButton();
                button.Content = $"Button {i + 1} with small and CAPITAL letters";
                grid.AddButton(button);
            }

            for (int i=0; i < textBoxesCount; i++)
            {
                ITextBox textBox = factory.CreateTextBox();
                textBox.Content = $"Text box {i + 1}, small, CAPITAL letters";
                grid.AddTextBox(textBox);
            }

            Console.WriteLine("Pressing first button");
            grid.GetButtons().First().ButtonPressed();
            Console.WriteLine(String.Empty);

            Console.WriteLine("Pressing all the buttons and displaying their contents");
            foreach (IButton button in grid.GetButtons())
            {
                button.ButtonPressed();
                button.DrawContent();
                Console.WriteLine(String.Empty);
            }   
        }
	}
}
