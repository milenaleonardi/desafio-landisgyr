using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    internal class Menu
    {
        public static void DisplayMenuOption(string menuOption)
        {
            // Adding number of letters for 'Menu' + extras -
            int decorationSize = 5 + menuOption.Length;
            string dashes = string.Empty.PadLeft(decorationSize, '-');

            Console.Clear();
            Console.WriteLine(dashes);
            Console.WriteLine($"Menu: {menuOption}");
            Console.WriteLine(dashes);
            Console.WriteLine();
        }
    }
}
