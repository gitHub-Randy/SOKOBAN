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

        public override  void Move(StaticObject destiantion, StaticObject current)
        {
            if(destiantion.Object == null)
            {
                destiantion.Object = this;
                destiantion.setDefaultSymbol();
                current.Object = null;
                current.setDefaultSymbol();
               
            }

            Console.Clear();

        }

        

     
    }
}