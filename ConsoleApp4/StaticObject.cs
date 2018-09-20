using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public abstract class StaticObject
    {
        public StaticObject NorthField
        {
            get => default(StaticObject);
            set
            {
            }
        }

        public StaticObject SouthField
        {
            get => default(StaticObject);
            set
            {
            }
        }

        public StaticObject EastField
        {
            get => default(StaticObject);
            set
            {
            }
        }

        public StaticObject WestField
        {
            get => default(StaticObject);
            set
            {
            }
        }
    }
}