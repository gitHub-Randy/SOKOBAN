using System;
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
                                    if (_parser.objects[i, j].WestField.Symbol != '#')
                                    {
                                        _parser.objects[i, j].WestField.Object = _parser.objects[i, j].Object;
                                        _parser.objects[i, j].WestField.setDefaultSymbol();
                                        _parser.objects[i, j].Object = null;
                                        _parser.objects[i, j].setDefaultSymbol();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        Console.WriteLine("links");
                                        // moveLeft //
                                        return;
                                    }
                                    return;
                                case ConsoleKey.RightArrow:
                                    if (_parser.objects[i, j].EastField.Symbol != '#')
                                    {
                                        _parser.objects[i, j].EastField.Object = _parser.objects[i, j].Object;
                                        _parser.objects[i, j].EastField.setDefaultSymbol();
                                        _parser.objects[i, j].Object = null;
                                        _parser.objects[i, j].setDefaultSymbol();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        Console.WriteLine("rechts");
                                        // moveright //
                                        return;
                                    } 
                                    return;
                                case ConsoleKey.UpArrow:
                                    if (_parser.objects[i, j].NorthField.Symbol != '#')
                                    {
                                        _parser.objects[i, j].NorthField.Object = _parser.objects[i, j].Object;
                                        _parser.objects[i, j].NorthField.setDefaultSymbol();
                                        _parser.objects[i, j].Object = null;
                                        _parser.objects[i, j].setDefaultSymbol();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        Console.WriteLine("omhoog");
                                        // moveup //
                                        return;
                                    }
                                    return;
                                case ConsoleKey.DownArrow:
                                    if (_parser.objects[i, j].SouthField.Symbol != '#')
                                    {
                                        _parser.objects[i, j].SouthField.Object = _parser.objects[i, j].Object;
                                        _parser.objects[i, j].SouthField.setDefaultSymbol();
                                        _parser.objects[i, j].Object = null;
                                        _parser.objects[i, j].setDefaultSymbol();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        Console.WriteLine("omlaag");
                                        // movedown //
                                        return;
                                    }
                                    return;
                            }
                            
                        }
                        
                        
                    }
                }
            }
           
        }
     
    }
}