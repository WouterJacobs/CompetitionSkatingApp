using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain
{
    public class EventCoordinator : IEventCoordinator
    {
        private string _firstName;
        private string _lastName;

        public EventCoordinator(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public override string ToString()
        {
            return $"FirstName: {_firstName}, LastName: {_lastName}";
        }
    }
}