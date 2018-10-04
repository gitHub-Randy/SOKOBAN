using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Muur : StaticObject
    {
        public override MovableObject Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void setDefaultSymbol()
        {
            this.Symbol = '#';
        }
    }
}