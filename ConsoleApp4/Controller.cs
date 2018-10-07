using System;

namespace ConsoleApp4
{
    public class Controller
    {
        private Doolhof _dh;
        private Parser _parser;
        private InputView _inputView;
        private ConsoleKeyInfo choice;
        private int level;
        private StaticObject[,] _board;
        private int numOfRows;
        private int lengthOfRows;
        private GameView gameView;
        public Controller()
        {
            _dh = new Doolhof();
            _parser = new Parser(this);
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
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
                    return;
                }
                if (choice.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    level = 2;
                    _parser.ParseLevel(2);
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
                    return;
                }
                if (choice.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    level = 3;
                    _parser.ParseLevel(3);
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
                    return;
                }
                if (choice.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    level = 4;
                    _parser.ParseLevel(4);
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
                    return;
                }
                if (choice.Key == ConsoleKey.D5)
                {
                    Console.Clear();
                    level = 5;
                    _parser.ParseLevel(5);
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
                    return;
                }
                if (choice.Key == ConsoleKey.D6)
                {
                    Console.Clear();
                    level = 6;
                    _parser.ParseLevel(6);
                    _board = _parser.Object;
                    numOfRows = _parser.NumberOfRows;
                    lengthOfRows = _parser.LengthOfRows;
                    gameView = new GameView(_board, numOfRows, lengthOfRows);
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

            
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    if (_board[i, j].Symbol == '@')
                    {
                        while (true)
                        {
                            choice = Console.ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.LeftArrow:
                                    if (_board[i, j].WestField.Symbol != '#' && _board[i, j].WestField.Symbol != 'o' && _board[i, j].WestField.Symbol != '0')
                                    {

                                        _board[i, j].Object.Move(_board[i, j].WestField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        
                                        return;
                                    }
                                    else if (_board[i, j].WestField.Symbol == 'o' || _board[i, j].WestField.Symbol == '0')
                                    {


                                        _board[i, j].WestField.Object.Move(_board[i, j].WestField.WestField, _board[i, j].WestField, false);
                                        _board[i, j].Object.Move(_board[i, j].WestField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;

                                    }
                                    return;
                                case ConsoleKey.RightArrow:
                                    if (_board[i, j].EastField.Symbol != '#' && _board[i, j].EastField.Symbol != 'o' && _board[i, j].EastField.Symbol != '0')
                                    {

                                        _board[i, j].Object.Move(_board[i, j].EastField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;
                                    }
                                    else if (_board[i, j].EastField.Symbol == 'o' || _board[i, j].EastField.Symbol == '0')
                                    {

                                        _board[i, j].EastField.Object.Move(_board[i, j].EastField.EastField, _board[i, j].EastField, false);
                                        _board[i, j].Object.Move(_board[i, j].EastField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;
                                    }
                                    return;
                                case ConsoleKey.UpArrow:
                                    if (_board[i, j].NorthField.Symbol != '#' && _board[i, j].NorthField.Symbol != 'o' && _board[i, j].NorthField.Symbol != '0')
                                    {
                                        _board[i, j].Object.Move(_board[i, j].NorthField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;
                                    }
                                    else if (_board[i, j].NorthField.Symbol == 'o' || _board[i, j].NorthField.Symbol == '0')
                                    {

                                        _board[i, j].NorthField.Object.Move(_board[i, j].NorthField.NorthField, _board[i, j].NorthField, false);
                                        _board[i, j].Object.Move(_board[i, j].NorthField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;

                                    }
                                    return;
                                case ConsoleKey.DownArrow:
                                    if (_board[i, j].SouthField.Symbol != '#' && _board[i, j].SouthField.Symbol != 'o' && _board[i, j].SouthField.Symbol != '0')
                                    {
                                        _board[i, j].Object.Move(_board[i, j].SouthField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;
                                    }
                                    else if (_board[i, j].SouthField.Symbol == 'o' || _board[i, j].SouthField.Symbol == '0')
                                    {
                                        _board[i, j].SouthField.Object.Move(_board[i, j].SouthField.SouthField, _board[i, j].SouthField, false);
                                        _board[i, j].Object.Move(_board[i, j].SouthField, _board[i, j], false);
                                        MoveSleeper();
                                        Console.Clear();
                                        gameView.Board = this._board;
                                        gameView.PrintObjects();
                                        return;
                                    }
                                    return;
                                case ConsoleKey.S:
                                    Console.Clear();
                                    _parser = new Parser(this);
                                    _inputView.ShowMenu();
                                    keyInputEvent();
                                    return;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    _parser = new Parser(this);
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
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    if (_board[i, j].Symbol == '$' || _board[i, j].Symbol == 'z'  )
                    {
                        _board[i, j].Object.Move(_board[i, j], _board[i, j], false);
                        return;
                    }
                }
            }
        }
        public bool CheckWin()
        {
            int barrelsOnDest = 0;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    if (_board[i, j].Symbol == '0')
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


        