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
           
            _inputView = new InputView();
            PlayGame();





        }

        private void PlayGame()
        {
            while (true)
            {
                _parser = new Parser(this);
                _inputView.ShowMenu();
                keyInputEvent();
                while (!CheckWin())
                {
                    KeyInputEventGame();
                }
                Console.Clear();

            }
        }



        public void makeLevel(int levelNew)
        {
            level = levelNew;
            Console.Clear();
            _parser.ParseLevel(levelNew);
            _board = _parser.Object;
            numOfRows = _parser.NumberOfRows;
            lengthOfRows = _parser.LengthOfRows;
            gameView = new GameView(_board, numOfRows, lengthOfRows);
            return;
        }

        private void keyInputEvent()
        {

            while (true)
            {
                choice = Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("> kies een doolhof ( 1 - 4), s = stop");

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        makeLevel(1);
                        return;
                    case ConsoleKey.D2:
                        makeLevel(2);
                        return;
                    case ConsoleKey.D3:
                        makeLevel(3);
                        return;
                    case ConsoleKey.D4:
                        makeLevel(4);
                        return;
                    case ConsoleKey.D5:
                        makeLevel(5);
                        return;
                    case ConsoleKey.D6:
                        makeLevel(6);
                        return;
                    case ConsoleKey.S:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Geef juiste input");
                        break;
                }

            }

        }


        private void MoveWest(int i, int j)
        {
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


        }

        private void MoveEast(int i, int j)
        {
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


        }

        private void MoveNorth(int i, int j)
        {
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

        }

        private void MoveSouth(int i, int j)
        {
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
                                    MoveWest(i, j);
                                    return;
                                case ConsoleKey.RightArrow:
                                    MoveEast(i, j);
                                    return;
                                case ConsoleKey.UpArrow:
                                    MoveNorth(i, j);
                                    return;
                                case ConsoleKey.DownArrow:
                                    MoveSouth(i, j);
                                    return;
                                case ConsoleKey.S:
                                    goBackToMenu();
                                    return;
                                case ConsoleKey.R:
                                    resetLevel();
                                    return;
                            }

                        }


                    }
                }
            }

        }

        public void goBackToMenu()
        {
            Console.Clear();
            _parser = new Parser(this);
            _inputView.ShowMenu();
            keyInputEvent();

        }

        public void resetLevel()
        {
            _parser = new Parser(this);
            _parser.ParseLevel(level);
            _board = _parser.Object;
            numOfRows = _parser.NumberOfRows;
            lengthOfRows = _parser.LengthOfRows;
            gameView = new GameView(_board, numOfRows, lengthOfRows);
            Console.Clear();
            gameView.PrintObjects();
        }



        public void MoveSleeper()
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    if (_board[i, j].Symbol == '$' || _board[i, j].Symbol == 'z')
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


