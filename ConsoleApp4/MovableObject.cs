using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public abstract class MovableObject
    {

        public Char Symbol
        {
            get => default(char);
            set
            {
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