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

        public override void Move(StaticObject destination, StaticObject current)
        {
         

            if (destination.Object == null && destination.Symbol != '#')
            {
                destination.Object = this;
                destination.setDefaultSymbol();
                current.Object = null;
                current.setDefaultSymbol();

            }
        }
    }
}