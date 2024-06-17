using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public class MainPageViewModel
    {
        
        public MainPageViewModel()
        {
            _hello = "hello world";
        }
        private string _hello;

        public string Hello
        {
            get { return _hello; }
            set { _hello = value; }
        }


    }
}

