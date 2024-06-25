using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class EventSchool : IEventSchool
    {
        private string _name;
        private IAddress _address;
        private string _owner;

        internal EventSchool(string name, IAddress address, string owner)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _address = address ?? throw new ArgumentNullException(nameof(address));
            _owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public IAddress Address
        {
            get => _address;
            set => _address = value;
        }

        public string Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Address: {_address}, Owner: {_owner}";
        }
    }
}
