using System;

namespace ConsoleApp4
{
    class Sleeper : MovableObject
    {

        public Sleeper()
        {
            this.Symbol = '$';
        }
        public override bool Move(StaticObject destiantion, StaticObject current, bool wakeUp)
        {
           
            if (wakeUp)
            {
                return WakeUp(current);
            }
            Random rnd = new Random();
            int wheelOfFortune = rnd.Next(1, 101);
            if (this.Symbol == 'z')
            {
                if (wheelOfFortune <= 10)
                {
                    return WakeUp(current);

                }
            }
            else
            {
                if (wheelOfFortune <= 25)
                {
                    return Sleep(current);
                }
                else
                {
                    return WakeUp(current);
                }
            }
            //if (destiantion.Object == null)
            //{
            //    destiantion.Object = this;
            //    destiantion.setDefaultSymbol();
            //    current.Object = null;
            //    current.setDefaultSymbol();

            //}

            Console.WriteLine(wheelOfFortune + " wof");
            return true;
        }

        public bool Sleep(StaticObject current)
        {
            this.Symbol = 'z';
            current.Object = this;
            current.setDefaultSymbol();
            return true;
        }

        public bool WakeUp(StaticObject current)
        {
            this.Symbol = '$';
 
            current.setDefaultSymbol();

            Random rnd = new Random();
            int direction = rnd.Next(1, 5);
            Console.WriteLine(direction + "direction");
            switch (direction)
            {

                case 1:
                    if (current.NorthField.Object == null && current.NorthField.Symbol != '#')
                    {
                        current.NorthField.Object = this;
                        current.NorthField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();
                        return true;
                    }
                    else if (current.NorthField.Object != null)
                    {
                        if (current.NorthField.Object.Symbol == '@')
                        {
                            if (current.NorthField.Object.Move(current.NorthField.NorthField, current.NorthField, false))
                            {
                                current.NorthField.Object = this;
                                current.NorthField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                        else if (current.NorthField.Object.Symbol == 'o' || current.NorthField.Object.Symbol == '0')
                        {
                            if (current.NorthField.Object.Move(current.NorthField.NorthField, current.NorthField, false))
                            {
                                current.NorthField.Object = this;
                                current.NorthField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                    }
                    break;
                case 2:
                    if (current.EastField.Object == null && current.EastField.Symbol != '#')
                    {
                        current.EastField.Object = this;
                        current.EastField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();
                        return true;
                    }
                    else if (current.EastField.Object != null)
                    {
                        if (current.EastField.Object.Symbol == '@')
                        {
                            if (current.EastField.Object.Move(current.EastField.EastField, current.EastField, false))
                            {
                                current.EastField.Object = this;
                                current.EastField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                        else if (current.EastField.Object.Symbol == 'o' || current.EastField.Object.Symbol == '0')
                        {
                            if (current.EastField.Object.Move(current.EastField.EastField, current.EastField, false))
                            {
                                current.EastField.Object = this;
                                current.EastField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                    }
                    break;
                case 3:
                    if (current.SouthField.Object == null && current.SouthField.Symbol != '#')
                    {
                        current.SouthField.Object = this;
                        current.SouthField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();
                        return true;
                    }
                    else if (current.SouthField.Object != null)
                    {
                        if (current.SouthField.Object.Symbol == '@')
                        {
                            if (current.SouthField.Object.Move(current.SouthField.SouthField, current.SouthField, false))
                            {
                                current.SouthField.Object = this;
                                current.SouthField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                        else if (current.SouthField.Object.Symbol == 'o' || current.SouthField.Object.Symbol == '0')
                        {
                            if (current.SouthField.Object.Move(current.SouthField.SouthField, current.SouthField, false))
                            {
                                current.SouthField.Object = this;
                                current.SouthField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                    }
                    break;
                case 4:
                    if (current.WestField.Object == null && current.WestField.Symbol != '#')
                    {
                        current.WestField.Object = this;
                        current.WestField.setDefaultSymbol();
                        current.Object = null;
                        current.setDefaultSymbol();
                        return true;
                    }
                    else if (current.WestField.Object != null)
                    {
                        if (current.WestField.Object.Symbol == '@')
                        {
                            if (current.WestField.Object.Move(current.WestField.WestField, current.WestField, false))
                            {
                                current.WestField.Object = this;
                                current.WestField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                        else if (current.WestField.Object.Symbol == 'o' || current.WestField.Object.Symbol == '0')
                        {
                            if (current.WestField.Object.Move(current.WestField.WestField, current.WestField, false))
                            {
                                current.WestField.Object = this;
                                current.WestField.setDefaultSymbol();
                                current.Object = null;
                                current.setDefaultSymbol();
                                return true;
                            }
                        }
                    }
                    break;
            }
            return false;

        }
    }
}
