﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public abstract class MovableObject
    {
        protected char _symbol;

        public Char Symbol
        {
            get { return this._symbol; }
            set
            {
                this._symbol = value;
            }
        }

        public  abstract bool Move(StaticObject destiantion, StaticObject current,bool WakeUP);
        
    }
}