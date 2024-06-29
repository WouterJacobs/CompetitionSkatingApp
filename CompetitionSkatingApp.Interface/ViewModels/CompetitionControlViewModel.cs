using CompetitionSkatingApp.Domain;
using CompetitionSkatingApp.Domain.Factories;
using CompetitionSkatingApp.Domain.Interfaces;
using CompetitionSkatingApp.Domain.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public class CompetitionControlViewModel : ViewModelBase, ICompetitionControlViewModel
    {
        private ICompetitionFactory _competitionFactory;
        private IDancingEvent _dancingEvent;
        private bool _canAddCompetition;
        public bool CanAddCompetition
        {
            get => _canAddCompetition;
            set
            {
                if (_canAddCompetition != value)
                {
                    _canAddCompetition = value;
                    RaisePropertyChanged();
                }
            }
        }

        public IDancingEvent DancingEvent
        {
            get => _dancingEvent;
            set
            {
                _dancingEvent = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(EventName));
                RaisePropertyChanged(nameof(Competitions));
            }
        }

        public ObservableCollection<ICompetition> Competitions
        {
            get => new ObservableCollection<ICompetition>(_dancingEvent?.Competitions ?? new List<ICompetition>());
            set
            {
                if (_dancingEvent != null)
                {
                    _dancingEvent.Competitions = value.ToList();
                    RaisePropertyChanged();
                }
            }
        }

        public string EventName
        {
            get => _dancingEvent?.Name ?? "nothing selected";
            set
            {
                if (_dancingEvent != null)
                {
                    _dancingEvent.Name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public CompetitionControlViewModel(ICompetitionFactory competitionFactory)
        {
            _competitionFactory = competitionFactory;
            _dancingEvent = null;
            _canAddCompetition = false;
        }


        public void CreateNewEvent(string eventName)
        {
            EventFactory eventFactory = new EventFactory();
            IEventCoordinator organizer = new EventCoordinator("John", "Doe");
            IEventCoordinator masterOfCeremony = new EventCoordinator("Jane", "Smith");
            IEventCoordinator diskjockey = new EventCoordinator("DJ", "Mike");

            EventTeam eventTeam = new EventTeam(organizer, masterOfCeremony, diskjockey);
            eventTeam.AddChairman(new Adjudicator("Chief", "Judge"));
            eventTeam.AddScrutineer(new EventCoordinator("Scrutineer", "1"));
            eventTeam.AddScrutineer(new EventCoordinator("Scrutineer", "2"));

            IEventLocation location = new EventLocation("Belgium", "Maasmechelen");
            IEventSchool school = new EventSchool("Dance Academy", new Address("USA", "New York", "10001", "5th Avenue", 123), "Donaat");
            IDancingEvent dancingEvent = eventFactory.CreateEvent(eventName, new DateOnly(2024, 6, 1), new DateOnly(2024, 6, 5), location, school, "A week-long celebration of dance.", eventTeam);

            DancingEvent = dancingEvent;

            DbWriter dbWriter = new();
            dbWriter.MakeNewDatabaseFile(dancingEvent);
        }

        public void AddCompetitionToEvent(string competitionName)
        {
            if (_dancingEvent != null)
            {
                ICompetition newCompetition = _competitionFactory.CreateCompetition(competitionName, Discipline.STANDARD, 5, AgeCategory.UNDER35, null);
                _dancingEvent.Competitions.Add(newCompetition);
                RaisePropertyChanged(nameof(Competitions)); // Notify that the Competitions property has changed
            }
        }
        public void UpdateEventDetails()
        {
            // Modify the dancingEvent details as needed
            //RaisePropertyChanged(nameof(DancingEvent)); // Ensure UI updates if necessary

            DbWriter dbWriter = new DbWriter();
            dbWriter.UpdateDatabaseFile(DancingEvent); // Update the existing file
        }
        protected override void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.RaisePropertyChanged(propertyName);
            if (propertyName == nameof(DancingEvent))
            {
                CanAddCompetition = DancingEvent != null;
            }
        }
    }
}
