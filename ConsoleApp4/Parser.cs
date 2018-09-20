using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Parser
    {
        Controller _controller;
        public Parser(Controller control)
        {
            _controller = control;
            ParseLevel();
        }
        public void ParseLevel()
        {
            String line;
            int counter = 0;
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader("doolhof4.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}