using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class InputView
    {
        public void ShowMenu()
        {
            Console.WriteLine(" ____________________________________________________");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Welkom bij Sokoban                                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| betekenis van de symbolen   | doel van het spel   |");
            Console.WriteLine("|                             |                     |");
            Console.WriteLine("| spatie : outerspace         | duw met de truck    |");
            Console.WriteLine("|      █ : muur               | de krat(ten)        |");
            Console.WriteLine("|      . : vloer              | naar de bestemming  |");
            Console.WriteLine("|      0 : krat               |                     |");
            Console.WriteLine("|      Ø : krat op bestemming |                     |");
            Console.WriteLine("|      x : bestemming         |                     |");
            Console.WriteLine("|      @ : truck              |                     |");
            Console.WriteLine("|___________________________________________________|");
            Console.WriteLine(" ");
            Console.WriteLine("> kies een doolhof ( 1 - 4), s = stop");
        }
    }
}