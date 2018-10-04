using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public abstract class StaticObject
    {
       private  StaticObject _northField;
        private StaticObject _southField;
        private StaticObject _eastField;
        private StaticObject _westField;
        private char _symbol;
        private MovableObject _object;

        public StaticObject NorthField
        {
            get { return this._northField; }
            set
            {
                this._northField = value;
            }
        }

        public StaticObject SouthField
        {
            get { return this._southField; }
            set
            {
                this._southField = value;
            }
        }

        public StaticObject EastField
        {
            get { return this._eastField; }
            set
            {
                this._eastField = value;
            }
        }

        public StaticObject WestField
        {
            get { return  this._westField; }
            set
            {
                this._westField = value;
            }
        }

        public char Symbol
        {
            get { return this._symbol; }
            set
            {
                this._symbol = value;
            }
        }

        public abstract MovableObject Object
        {
            get;
            set;
        }
    }
}