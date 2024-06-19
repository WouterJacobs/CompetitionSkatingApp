using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Address : IAddress
    {
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostalCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
