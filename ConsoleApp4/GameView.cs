using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class GameView
    {
        private StaticObject[,] _board;
        private int numOfRows;
        private int lengthOfRows;
        public GameView(StaticObject[,] board,int numOfRows, int lengthOfRows)
        {
            _board = board;
            this.numOfRows = numOfRows;
            this.lengthOfRows = lengthOfRows;
            PrintObjects();
        }

        public void PrintObjects()
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < lengthOfRows; j++)
                {
                    Console.Write(_board[i, j].Symbol);
                }
                Console.WriteLine();
            }
        }


        public StaticObject[,] Board
        {
            get { return this._board; }
            set
            {
                this._board = value;
            }
        }
        public int NumberOfRows
        {
            get { return this.numOfRows; }
            set
            {
                this.numOfRows = value;
            }
        }

        public int LengthOfRows
        {
            get { return this.lengthOfRows; }
            set
            {
                this.lengthOfRows = value;
            }
        }
    }
}
