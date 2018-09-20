using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public  class Controller 
    {
        String _string = "he";
        private Doolhof _dh;
        private Parser _parser;
        private OutputView _outputView;
        private InputView _inputView;
        public Controller()
        {
            _dh = new Doolhof();
            _parser = new Parser(this);
            _outputView = new OutputView();
            _inputView = new InputView();
            //_inputView.ShowMenu();
           
           
        }

       
     
    }
}