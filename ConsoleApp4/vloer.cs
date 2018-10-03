using System;

namespace ConsoleApp4
{
    public class Vloer : StaticObject
    {

        private MovableObject _object;
        public Vloer(char c, bool hasTruck, bool hasKist)
        {
            if (c == '@')
            {

                this.hasTruck = true;

            }
            else if (c == 'o')
            {

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

        public override MovableObject HasObject
        {
            get { return this._object; }
            set { this._object = value; }

        }
    }
}