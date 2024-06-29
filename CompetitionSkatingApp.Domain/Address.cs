using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    public class Address : IAddress
    {
        private string _country;
        private string _city;
        private string _postalCode;
        private string _street;
        private int _number;

        public Address(string country, string city, string postalCode, string street, int number)
        {
            _country = country ?? throw new ArgumentNullException(nameof(country));
            _city = city ?? throw new ArgumentNullException(nameof(city));
            _postalCode = postalCode ?? throw new ArgumentNullException(nameof(postalCode));
            _street = street ?? throw new ArgumentNullException(nameof(street));
            _number = number;
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

        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public override string ToString()
        {
            return $"City: {_city}, PostalCode: {_postalCode}, Street: {_street}, Number: {_number}";
        }
    }
}
