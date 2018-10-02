﻿using System;

namespace ConsoleApp4
{
    public class Parser : IParser
    {
        Controller _controller;
        StaticObject[,] objects;
        int numberOfRows;
        int lengthOfRows;
        String[] lines;
        Char[,] char2d;
        public Parser(Controller control)
        {
            _controller = control;
            ParseLevel();
        }
        public override void ParseLevel()
        {
            lines = System.IO.File.ReadAllLines("doolhof4.txt");
            numberOfRows = lines.Length;
            lengthOfRows = lines[0].Length;
            char2d = new Char[numberOfRows, lengthOfRows];
            objects = new StaticObject[numberOfRows, lengthOfRows];

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
                            objects[i, j] = new Muur();
                            objects[i, j].Symbol = '#';
                            break;
                        case '.':
                            //MakeFloor();
                            objects[i, j] = new Vloer('.', false, false);
                            objects[i, j].Symbol = '.';
                            break;
                        case '@':
                            //MakeTruck();
                            objects[i, j] = new Vloer('@', true, false);
                            objects[i, j].Symbol = '@';
                            break;
                        case 'o':
                            //MakeBox();
                            objects[i, j] = new Vloer('o', false, true);
                            objects[i, j].Symbol = 'o';
                            break;
                        case 'x':
                            //MakeDestination();
                            objects[i, j] = new Destination();
                            objects[i, j].Symbol = 'x';
                            break;
                        case ' ':
                            //MakeEmptySpace();
                            objects[i, j] = new EmptySpace();
                            objects[i, j].Symbol = '█';
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
                        objects[i, j].NorthField = objects[i - 1, j];
                    }
                    if (i < numberOfRows)
                    {
                        objects[i, j].SouthField = objects[i + 1, j];
                    }
                    if (j > 0)
                    {
                        objects[i, j].WestField = objects[i, j - 1];
                    }
                    if (j < lengthOfRows - 1)
                    {
                        objects[i, j].EastField = objects[i, j + 1];
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
                    Console.Write(objects[i, j].Symbol);
                }
                Console.WriteLine();
            }
        }

    }


}

