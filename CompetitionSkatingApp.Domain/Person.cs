using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Person : IPerson
    {
        private string _firstName;
        private string _lastName;

        internal Person(string firstName, string lastName)
        {
            _firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            _lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
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
