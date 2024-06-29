using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public interface ICompetitionControlViewModel
    {
        public string EventName { get; set; }
        public void CreateNewEvent(string eventName);
    }
}
