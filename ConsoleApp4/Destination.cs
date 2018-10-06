namespace ConsoleApp4
{
    public class Destination : StaticObject
    {

        public override MovableObject Object
        {
            get { return this._object; }
            set
            {
                this._object = value;
                if (_object != null)
                {
                    if (_object.Symbol == '@')
                    {
                        this.Symbol = '@';
                    }
                    else if (_object.Symbol == 'o')
                    {
                        this.Symbol = '0';
                    }
                }
                else
                {
                    this.Symbol = '0';
                }
                
                

            }
        }

        public override void setDefaultSymbol()
        {
            if (this._object == null)
            {
                this.Symbol = 'x';
            }
            else
            {
                this.Symbol = _object.Symbol;
            }
            if(this.Symbol == 'o')
            {
                this.Symbol = '0';
            }
            
        }
    }
}