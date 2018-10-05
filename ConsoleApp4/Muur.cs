using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Muur : StaticObject
    {
        public override MovableObject Object { get { return null; } set { return; } }

        public override void setDefaultSymbol()
        {
            this.Symbol = '#';
        }
    }
}