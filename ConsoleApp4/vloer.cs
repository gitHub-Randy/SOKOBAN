using System;

namespace ConsoleApp4
{
    public class Vloer : StaticObject
    {

        
        public Vloer(char c, bool hasTruck, bool hasKist)
        {

        }


        public override void setDefaultSymbol()
        {
            if(this._object == null)
            {
                this.Symbol = '.';
            }
            else
            {
                this.Symbol = this._object.Symbol;
            }
        }

        public bool hasTruck
        {
            get => default(bool);
            set
            {
            }


        }
        public bool hasKist
        {
            get => default(bool);
            set
            {
            }
        }

        public override MovableObject Object
        {
            get { return this._object; }
            set { this._object = value; }

        }
    }
}