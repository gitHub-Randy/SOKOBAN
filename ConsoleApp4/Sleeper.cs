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
            Random rnd = new Random();
            int wheelOfFortune = rnd.Next(1, 101);
            if(this.Symbol == 'z')
            {
                if(wheelOfFortune <= 10)
                {
                    WakeUp(current);
                }
            }
            else
            {
                if(wheelOfFortune <= 25)
                {
                    Sleep();
                }
            }
            if (destiantion.Object == null)
            {
                destiantion.Object = this;
                destiantion.setDefaultSymbol();
                current.Object = null;
                current.setDefaultSymbol();

            }
        }

        public void Sleep()
        {
            this.Symbol = 'z';
        }

        public void WakeUp(StaticObject current)
        {
            this.Symbol = '$';


        }
    }
}
