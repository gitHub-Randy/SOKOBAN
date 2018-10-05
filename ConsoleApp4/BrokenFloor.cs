namespace ConsoleApp4
{
    class BrokenFloor : StaticObject
    {
        private MovableObject _object;
        int numberOfObjects;
        public override MovableObject Object
        {
            get { return this._object; }
            set { this._object = value; }

        }

        public override void setDefaultSymbol()
        {
            if (this._object == null)
            {
                this.Symbol = '~';
            }
            if (numberOfObjects > 2 && this._object == null)
            {
                this.Symbol = ' ';
            }

           
            if(this._object != null)
            {
                if (this._object.Symbol == '@')
                {
                    this.Symbol = this._object.Symbol;
                    numberOfObjects++;
                }
                if (this._object.Symbol == 'o')
                {
                    numberOfObjects++;
                    if (numberOfObjects > 2)
                    {
                        this._object = null;
                    }
                    else
                    {
                        this.Symbol = this._object.Symbol;
                    }
                }
            }
           
            //else
            //{

            //    numberOfObjects++;
            //    if (numberOfObjects > 2)
            //    {
            //        if (this.Symbol == 'o')
            //        {
            //            this._object = null;
            //            this.Symbol = ' ';
            //        }
            //    }
            //    else
            //    {
            //        this.Symbol = this._object.Symbol;
            //    }
            }



        }
    }

