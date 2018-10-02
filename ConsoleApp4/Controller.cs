﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public  class Controller 
    {
        String _string = "he";
        private Doolhof _dh;
        private Parser _parser;
        private OutputView _outputView;
        private InputView _inputView;
        private ConsoleKeyInfo choice;
        public Controller()
        {
            _dh = new Doolhof();
            _parser = new Parser(this);
            _outputView = new OutputView();
            _inputView = new InputView();
            //_inputView.ShowMenu();
            //keyInputEvent();

            while (true)
            {
                KeyInputEventGame();
            }



        }

       private void keyInputEvent()
        {
            
            do
            {
                choice = Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("> kies een doolhof ( 1 - 4), s = stop");
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Level 1");
                }
            }
            while (choice.Key != ConsoleKey.S);
        }

       private void KeyInputEventGame()
        {
            ConsoleKey choice;

            
            for (int i = 0; i < _parser.numberOfRows; i++)
            {
                for (int j = 0; j < _parser.lengthOfRows; j++)
                {
                    if (_parser.objects[i,j].Symbol == '@')
                    {
                        while (true)
                        {
                            choice = Console.ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.LeftArrow:
                                    _parser.objects[i, j - 1].Symbol = '@';
                                    _parser.objects[i, j].Symbol = '.';
                                    Console.Clear();
                                    _parser.PrintObjects();
                                    Console.WriteLine("links");
                                    // moveLeft //
                                    return;
                                case ConsoleKey.RightArrow:
                                    Console.WriteLine("rechts");
                                    // moveright //
                                    break;
                                case ConsoleKey.UpArrow:
                                    Console.WriteLine("omhoog");
                                    // moveup //
                                    break;
                                case ConsoleKey.DownArrow:
                                    Console.WriteLine("omlaag");
                                    // movedown //
                                    break;

                            }
                            
                        }
                        
                        
                    }
                }
            }
           
        }
     
    }
}