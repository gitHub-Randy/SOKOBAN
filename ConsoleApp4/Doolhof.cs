using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Doolhof
    {
        MagazijnMedewerker mw = new MagazijnMedewerker();
        Muur m = new Muur();
        Vloer v = new Vloer();
        Kist k = new Kist();
        Destination d = new Destination();

        public int Maze
        {
            get => default(int);
            set
            {
            }
        }
    }
}