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
                if(wheelOfFortune <= 0)
                {
                    Sleep(current);
                }
                else
                {
                    WakeUp(current);
                }
            }
            //if (destiantion.Object == null)
            //{
            //    destiantion.Object = this;
            //    destiantion.setDefaultSymbol();
            //    current.Object = null;
            //    current.setDefaultSymbol();

            //}
            Console.WriteLine(wheelOfFortune+" wof");
        }

        public void Sleep(StaticObject current)
        {
            this.Symbol = 'z';
            current.Object = this;
            current.setDefaultSymbol();
        }

        public void WakeUp(StaticObject current)
        {
            this.Symbol = '$';
            current.Object = this;
            current.setDefaultSymbol();

            Random rnd = new Random();
            int direction = rnd.Next(1, 5);
            Console.WriteLine(direction + "direction");
            switch (direction)
            {
                
                case 1:
                    if(current.NorthField.Object == null && current.NorthField.Symbol != '#')
                    {
                        current.NorthField.Object = this;
                        current.NorthField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();

                    }
                    break;
                case 2:
                    if (current.EastField.Object == null)
                    {
                        current.EastField.Object = this;
                        current.EastField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();

                    }
                    break;
                case 3:
                    if (current.SouthField.Object == null)
                    {
                        current.SouthField.Object = this;
                        current.SouthField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();

                    }
                    break;
                case 4:
                    if (current.WestField.Object == null)
                    {
                        current.WestField.Object = this;
                        current.WestField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();

                    }
                    break;
                default:
                    Console.WriteLine("direction not between 1 -4");
                    break;
            }
          
        }
    }
}
