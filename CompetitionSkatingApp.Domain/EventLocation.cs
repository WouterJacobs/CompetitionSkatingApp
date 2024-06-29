using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain
{
    public class EventLocation : IEventLocation
    {
        private string _country;
        private string _city;

        public EventLocation(string country, string city)
        {
            _country = country ?? throw new ArgumentNullException(nameof(country));
            _city = city ?? throw new ArgumentNullException(nameof(city));
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public override string ToString()
        {
            return $"Country: {_country}, City: {_city}";
        }
    }
}