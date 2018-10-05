using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Sleeper : MovableObject
    {

        public Sleeper()
        {
            this.Symbol = '$';
        }
        public override void Move(StaticObject destiantion, StaticObject current)
        {
            throw new NotImplementedException();
        }
    }
}
