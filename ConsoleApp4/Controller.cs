using System;

namespace ConsoleApp4
{
    public class Controller
    {
        private Doolhof _dh;
        private Parser _parser;
        private OutputView _outputView;
        private InputView _inputView;
        private ConsoleKeyInfo choice;
        private int level;
        public Controller()
        {
            _dh = new Doolhof();
            _parser = new Parser(this);
            _outputView = new OutputView();
            _inputView = new InputView();
            _inputView.ShowMenu();
            keyInputEvent();

            while (!CheckWin())
            {
                KeyInputEventGame();
            }



        }

        private void keyInputEvent()
        {

            while (true)
            {
                choice = Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("> kies een doolhof ( 1 - 4), s = stop");
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    level = 1;
                    _parser.ParseLevel(1);
                    return;
                }
                if (choice.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    level = 2;
                    _parser.ParseLevel(2);
                    return;
                }
                if (choice.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    level = 3;
                    _parser.ParseLevel(3);
                    return;
                }
                if (choice.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    level = 4;
                    _parser.ParseLevel(4);
                    return;
                }
                if (choice.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    level = 5;
                    _parser.ParseLevel(5);
                    return;
                }
                if (choice.Key == ConsoleKey.D6)
                {
                    Console.Clear();
                    level = 6;
                    _parser.ParseLevel(6);
                    return;
                }
                if (choice.Key == ConsoleKey.S)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Geef juiste input");
                continue;
            }
            
        }

        private void KeyInputEventGame()
        {
            ConsoleKey choice;

            
            for (int i = 0; i < _parser.NumberOfRows; i++)
            {
                for (int j = 0; j < _parser.LengthOfRows; j++)
                {
                    if (_parser.Object[i, j].Symbol == '@')
                    {
                        while (true)
                        {
                            choice = Console.ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.LeftArrow:
                                    if (_parser.Object[i, j].WestField.Symbol != '#' && _parser.Object[i, j].WestField.Symbol != 'o' && _parser.Object[i, j].WestField.Symbol != '0')
                                    {

                                         _parser.Object[i, j].Object.Move(_parser.Object[i, j].WestField, _parser.Object[i, j],false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    else if (_parser.Object[i, j].WestField.Symbol == 'o' || _parser.Object[i, j].WestField.Symbol == '0')
                                    {


                                        _parser.Object[i, j].WestField.Object.Move(_parser.Object[i, j].WestField.WestField, _parser.Object[i, j].WestField, false);
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].WestField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;

                                    }
                                    return;
                                case ConsoleKey.RightArrow:
                                    if (_parser.Object[i, j].EastField.Symbol != '#' && _parser.Object[i, j].EastField.Symbol != 'o' && _parser.Object[i, j].EastField.Symbol != '0')
                                    {

                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].EastField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    else if (_parser.Object[i, j].EastField.Symbol == 'o' || _parser.Object[i, j].EastField.Symbol == '0')
                                    {

                                        _parser.Object[i, j].EastField.Object.Move(_parser.Object[i, j].EastField.EastField, _parser.Object[i, j].EastField, false);
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].EastField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    return;
                                case ConsoleKey.UpArrow:
                                    if (_parser.Object[i, j].NorthField.Symbol != '#' && _parser.Object[i, j].NorthField.Symbol != 'o' && _parser.Object[i, j].NorthField.Symbol != '0')
                                    {
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].NorthField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    else if (_parser.Object[i, j].NorthField.Symbol == 'o' || _parser.Object[i, j].NorthField.Symbol == '0')
                                    {

                                        _parser.Object[i, j].NorthField.Object.Move(_parser.Object[i, j].NorthField.NorthField, _parser.Object[i, j].NorthField, false);
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].NorthField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;

                                    }
                                    return;
                                case ConsoleKey.DownArrow:
                                    if (_parser.Object[i, j].SouthField.Symbol != '#' && _parser.Object[i, j].SouthField.Symbol != 'o' && _parser.Object[i, j].SouthField.Symbol != '0')
                                    {
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].SouthField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    else if (_parser.Object[i, j].SouthField.Symbol == 'o' || _parser.Object[i, j].SouthField.Symbol == '0')
                                    {
                                        _parser.Object[i, j].SouthField.Object.Move(_parser.Object[i, j].SouthField.SouthField, _parser.Object[i, j].SouthField, false);
                                        _parser.Object[i, j].Object.Move(_parser.Object[i, j].SouthField, _parser.Object[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        _parser.PrintObjects();
                                        return;
                                    }
                                    return;
                                case ConsoleKey.S:
                                    Console.Clear();
                                    _inputView.ShowMenu();
                                    keyInputEvent();
                                    return;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    _parser.ParseLevel(level);
                                    return;
                            }

                        }


                    }
                }
            }

        }

        public void MoveSleeper()
        {
            for (int i = 0; i < _parser.NumberOfRows; i++)
            {
                for (int j = 0; j < _parser.LengthOfRows; j++)
                {
                    if (_parser.Object[i, j].Symbol == '$' || _parser.Object[i, j].Symbol == 'z'  )
                    {
                        _parser.Object[i, j].Object.Move(_parser.Object[i, j], _parser.Object[i, j], false);
                        return;
                    }
                }
            }
        }
        public bool CheckWin()
        {
            int barrelsOnDest = 0;
            for (int i = 0; i < _parser.NumberOfRows; i++)
            {
                for (int j = 0; j < _parser.LengthOfRows; j++)
                {
                    if (_parser.Object[i, j].Symbol == '0')
                    {
                        barrelsOnDest++;
                    }
                }
            }
            if (barrelsOnDest == _parser.NumOfKist)
            {
                return true;
            }
            return false;

        }
    }
}


        