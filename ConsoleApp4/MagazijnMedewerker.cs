using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class MagazijnMedewerker : MovableObject
    {
        
       public MagazijnMedewerker()
        {
            this.Symbol = '@';
            
        }

        public override  bool Move(StaticObject destiantion, StaticObject current,bool WakeUp)
        {
            if(destiantion.Object == null && destiantion.Symbol != '#' )
            {
                destiantion.Object = this;
                destiantion.setDefaultSymbol();
                current.Object = null;
                current.setDefaultSymbol();
                return true;
            }
            else if(destiantion.Object != null)
            {
                 if (destiantion.Object.Symbol == 'z')
                {
                    if (destiantion.Object.Move(destiantion, destiantion, true))
                    {
                        destiantion.Object = this;
                        destiantion.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();
                        return true;
                    }
                }
            
            }


            return false;

        }

        

     
    }
}