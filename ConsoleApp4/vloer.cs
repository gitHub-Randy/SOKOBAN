using System;

namespace ConsoleApp4
{
    public class Vloer : StaticObject
    {

        
      

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

      
        public override MovableObject Object
        {
            get { return this._object; }
            set { this._object = value; }

        }
    }
}