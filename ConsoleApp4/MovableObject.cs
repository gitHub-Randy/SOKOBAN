using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public abstract class MovableObject
    {
        private char _symbol;

        public Char Symbol
        {
            get { return this._symbol; }
            set
            {
                this._symbol = value;
            }
        }

        public int Position
        {
            get => default(int);
            set
            {
            }
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}