using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Club : IClub
    {
        private string _name;
        private IAddress _address;

        internal Club(string name, IAddress address)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _address = address ?? throw new ArgumentNullException(nameof(address));
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

        public override string ToString()
        {
            return $"Name: {_name}, Address: {_address}";
        }
    }
}
