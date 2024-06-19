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
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
