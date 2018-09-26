using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Vloer : StaticObject
    {
    
        
        public Vloer(char c, bool hasTruck, bool hasKist)
        {
           if( c == '@')
            {
                this.Symbol = c;
                this.hasTruck = true;
                
            }
           else if(c == 'o')
            {
                this.Symbol = c;
                hasKist = true;

            }
        }

        public bool hasTruck
        {
            get => default(bool);
            set
            {
            }
        

    }
        public bool hasKist
        {
            get => default(bool);
            set
            {
            }
        }
    }
}