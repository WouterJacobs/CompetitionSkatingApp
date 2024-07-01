using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class DancingEvent : IDancingEvent
    {
        private string _name;
        private DateOnly _startDate;
        private DateOnly _endDate;
        private IEventLocation _location;
        private IEventSchool _school;
        private string _description;
        private IEventTeam _eventTeam;
        private IList<ICompetition> _competitions;


        internal DancingEvent(string name, DateOnly startDate, DateOnly endDate, IEventLocation location, IEventSchool school,
            string description, IEventTeam eventTeam)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _startDate = startDate;
            _endDate = endDate;
            _location = location ?? throw new ArgumentNullException(nameof(location));
            _school = school ?? throw new ArgumentNullException(nameof(school));
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _eventTeam = eventTeam ?? throw new ArgumentNullException(nameof(eventTeam));
            _competitions = new List<ICompetition>();
        }

        public DancingEvent()
        {
            _competitions = new List<ICompetition>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateOnly StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateOnly EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public IEventLocation Location
        {
            get => _location;
            set => _location = value;
        }

        public IEventSchool School
        {
            get => _school;
            set => _school = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public IEventTeam EventTeam
        {
            get => _eventTeam;
            set => _eventTeam = value;
        }

        public IList<ICompetition> Competitions
        {
            get => _competitions;
            set => _competitions = value;
        }

        public override string ToString()
        {
            return $"Name: {_name}, StartDate: {_startDate}, EndDate: {_endDate}, Location: {_location}, School: {_school}";
        }

        public void AddCompetition(ICompetition competition)
        {
            _competitions.Add(competition);
        }
    }
}
