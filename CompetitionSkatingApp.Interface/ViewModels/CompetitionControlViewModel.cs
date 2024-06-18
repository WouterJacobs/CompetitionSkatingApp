using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public class CompetitionControlViewModel : ViewModelBase, ICompetitionControlViewModel
    {
        private string _eventName;

		public string EventName
		{
			get { return _eventName; }
			set { _eventName = value; }
		}

        public CompetitionControlViewModel()
        {
            _eventName = "test";
        }
    }
}
