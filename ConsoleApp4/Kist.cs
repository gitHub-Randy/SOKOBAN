using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Kist : MovableObject
    {
       
        public Kist()
        {
            this.Symbol = 'o';
        }

        public override bool Move(StaticObject destination, StaticObject current,bool wakeUp)
        {
         

            if (destination.Object == null && destination.Symbol != '#')
            {
                destination.Object = this;
                destination.setDefaultSymbol();
                current.Object = null;
                current.setDefaultSymbol();
                return true;

            }
            return false;
        }
    }
}