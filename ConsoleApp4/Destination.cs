namespace ConsoleApp4
{
    public class Destination : StaticObject
    {

        private MovableObject _object;

      

        public override MovableObject Object
        {
            get { return this._object; }
            set
            {
                this._object = value;
                if (_object.Symbol == '@')
                {
                    this.Symbol = '@';
                }
                else if (_object.Symbol == 'o')
                {
                    this.Symbol = '0';
                }

            }
        }
    }
}