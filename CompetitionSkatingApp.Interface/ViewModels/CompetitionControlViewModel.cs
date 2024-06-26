using CompetitionSkatingApp.Domain.Factories;
using CompetitionSkatingApp.Domain.Interfaces;
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
        private  ICompetitionFactory _competitionFactory;

        private List<ICompetition> _competitions;

        public List<ICompetition> Competitions
        {
			get { return _competitions; }
			set { _competitions = value; }
		}


		public string EventName
		{
			get { return _eventName; }
			set { _eventName = value; }
		}

        public CompetitionControlViewModel(ICompetitionFactory competitionFactory)
        {
            _eventName = "test";
            _competitionFactory = competitionFactory;
			SeedCompetitions();
        }

		private void SeedCompetitions()
		{
			_competitions = new List<ICompetition>(){
				_competitionFactory.CreateCompetition("Adult Masterclass latin", Domain.Discipline.LATIN, 5, Domain.AgeCategory.ADULT, null),
				_competitionFactory.CreateCompetition("Adult Amateur Ballroom", Domain.Discipline.STANDARD, 4, Domain.AgeCategory.ADULT, null),
			};
		}
    }
}
