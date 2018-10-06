using System;

namespace ConsoleApp4
{
    public class Parser
    {
        private Controller _controller;
        private StaticObject[,] _object;
        private int numberOfRows;
        private int lengthOfRows;
        private String[] lines;
        private Char[,] char2d;
        private int numOfKist;
        public Parser(Controller control)
        {
            _controller = control;
            
        }

        public StaticObject[,] Object
        {
            get { return this._object; }
        }

        public int NumberOfRows
        {
            get { return numberOfRows; }
        }

        public int LengthOfRows
        {
            get { return lengthOfRows; }
        }

        public int NumOfKist
        {
            get { return numOfKist; }
        }
        public void ParseLevel(int level)
        {

            lines = System.IO.File.ReadAllLines("doolhof" + level + ".txt");
            numberOfRows = lines.Length;
            lengthOfRows = lines[0].Length;
            char2d = new Char[numberOfRows, lengthOfRows];
            _object = new StaticObject[numberOfRows, lengthOfRows];

            ReadTextFile();
            MakeObjects();
            LinkObjects();
            PrintObjects();

            
        }

        public void ReadTextFile()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                var s = lines[i].ToCharArray();

                for (int j = lengthOfRows - 1; j >= 0; j--)
                {
                    char2d[i, j] = s[j];
                }
            }
        }

        public void MakeObjects()
        {

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = lengthOfRows - 1; j >= 0; j--)
                {
                    char character = char2d[i, j];

                    switch (character)
                    {
                        case '#':
                            //MakeWall();
                            Object[i, j] = new Muur();
                            Object[i, j].setDefaultSymbol();
                            break;
                        case '.':
                            //MakeFloor();
                            Object[i, j] = new Vloer('.', false, false);
                            Object[i, j].setDefaultSymbol();
                            break;
                        case '@':
                            //MakeTruck();
                            Object[i, j] = new Vloer('@', true, false);
                            Object[i, j].Object = new MagazijnMedewerker();
                            Object[i, j].setDefaultSymbol();
                            break;
                        case 'o':
                            //MakeBox();
                            Object[i, j] = new Vloer('o', false, true);
                            Object[i, j].Object = new Kist();
                            Object[i, j].setDefaultSymbol();
                            numOfKist++;
                            break;
                        case 'x':
                            //MakeDestination();
                            Object[i, j] = new Destination();
                            Object[i, j].setDefaultSymbol();
                            
                            break;
                        case ' ':
                            //MakeEmptySpace();
                            Object[i, j] = new EmptySpace();
                            Object[i, j].setDefaultSymbol();
                            break;
                        case '~':
                           //MakeBrokenIsle
                            Object[i, j] = new BrokenFloor();
                            Object[i, j].setDefaultSymbol();
                            break;
                        case '$':
                            //MakeBrokenIsle
                            Object[i, j] = new Vloer('.',false,false);
                            Object[i, j].Object = new Sleeper();
                            Object[i, j].setDefaultSymbol();
                            break;
                        default:
                            break;

                    }
                }

            }

        }

        public void LinkObjects()
        {
            for (int i = 0; i < numberOfRows - 1; i++)
            {
                for (int j = lengthOfRows - 1; j > 0; j--)
                {

                    if (i > 0)
                    {
                        Object[i, j].NorthField = Object[i - 1, j];
                    }
                    if (i < numberOfRows)
                    {
                        Object[i, j].SouthField = Object[i + 1, j];
                    }
                    if (j > 0)
                    {
                        Object[i, j].WestField = Object[i, j - 1];
                    }
                    if (j < lengthOfRows - 1)
                    {
                        Object[i, j].EastField = Object[i, j + 1];
                    }
                }
            }
        }

        public void PrintObjects()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    Console.Write(Object[i, j].Symbol);
                }
                Console.WriteLine();
            }
        }

    }


}

