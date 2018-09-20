using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Parser : IParser
    {
        Controller _controller;
        List<char> _upper;
        List<char> _bottom;
        public Parser(Controller control)
        {
            _controller = control;
            ParseLevel();
        }
        public override void ParseLevel()
        {
            _upper = new List<char>();
            _bottom = new List<char>();

            String[] lines = System.IO.File.ReadAllLines("doolhof4.txt");

            for(int i = 0; i< lines.Length-1; i+=2)
            {
                _upper = lines[i].ToList();
                _bottom = lines[i + 1].ToList();
                Factory(_upper, _bottom);
              
            }

           
            System.Console.ReadLine();
        }

        public void Factory(List<char> lOne, List<char>lTwo)
        {
            for(int i =0; i< lOne.Count; i++)
            {
                char type = lOne[i];
                switch (type)
                {
                    case '#':
                        //MakeWall();
                        break;
                    case '.':
                        //MakeFloor();
                        break;
                    case '@':
                        //MakeTruck();
                        break;
                    case 'O':
                        //MakeBox();
                        break;
                    case 'x':
                        //MakeDestination();
                        break;
                    default:
                        break;
                }
            }
        }


    }
}