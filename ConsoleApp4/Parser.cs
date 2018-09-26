using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public class Parser : IParser
    {
        Controller _controller;
        List<char> _upper;
        List<char> _bottom;
        List<StaticObject> tempo = new List<StaticObject>();
        StaticObject _first;
        int test = 0;
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
            _upper = lines[0].ToList();

            for (int i = 1; i < lines.Length; i++)
            {
                _bottom = lines[i].ToList();
                Factory(_upper, _bottom);
                _upper = _bottom;

            }
            _first = tempo.First();

            StaticObject current = _first;
            while (current != null)
            {
                Console.Write(current.Symbol);
                if(current.EastField == null)
                {
                    Console.WriteLine();
                    current = _first.SouthField;
                    _first = current;
                }
                if(current.EastField != null)
                {
                    current = current.EastField;
                }
            }
                 
            //StaticObject[] tempoArr = tempo.ToArray();
            //for (int i = 0; i < tempoArr.Length; i++)
            //{
            //    if (tempoArr[i].EastField != null)
            //    {
                    
            //            Console.Write(tempoArr[i].Symbol);
                    

            //    }
            //    if (tempoArr[i].EastField == null)
            //    {
            //        Console.WriteLine();
            //    }
            //}



            System.Console.ReadLine();
        }

        public void Factory(List<char> lOne, List<char> lTwo)
        {


          
            LinkObjects(MakeObjects(lOne), MakeObjects(lTwo));

           
            


        }

        public void LinkObjects(StaticObject[] lOne, StaticObject[] lTwo)
        {
            
            
            
            for (int i = 0; i < lOne.Length - 1; i++)
            {
                
                lOne[i].EastField = lOne[i + 1];
                lOne[i].WestField = lOne[i + 1];
               

            }
           
            for (int i = 0; i < lOne.Length-1; i++)
            {
                lOne[i].SouthField = lTwo[i+1];
                lTwo[i].NorthField = lOne[i+1];

            }





            for (int i = 0; i < lOne.Length; i++)
            {
                tempo.Add(lOne[i]);
            }

            
            //for (int i = 0; i < lTwo.Length; i++)
            //{
            //    tempo.Add(lTwo[i]);
            //}

        }

        public StaticObject[] MakeObjects(List<char> list)
        {
            StaticObject[] objects = new StaticObject[list.Count()];
            
            for (int i = 0; i < list.Count; i++)
            {

                char type = list[i];
                switch (type)
                {
                    case '#':
                        //MakeWall();
                        objects[i] = new Muur();
                        objects[i].Symbol = '#';
                        break;
                    case '.':
                        //MakeFloor();
                        objects[i] = new Vloer('.', false, false);
                        objects[i].Symbol = '.';
                        break;
                    case '@':
                        //MakeTruck();
                        objects[i] = new Vloer('@', true, false);
                        objects[i].Symbol = '@';
                        break;
                    case 'o':
                        //MakeBox();
                        objects[i] = new Vloer('o', false, true);
                        objects[i].Symbol = 'o';
                        break;
                    case 'x':
                        //MakeDestination();
                        objects[i] = new Destination();
                        objects[i].Symbol = 'x';
                        break;
                    case ' ':
                        //MakeEmptySpace();
                        objects[i] = new EmptySpace();
                        objects[i].Symbol = ' ';
                        break;
                    default:
                        break;
                }
            }

            return objects;
        }


    }
}