using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Couple : ICouple
    {
        public IPerson Man { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPerson Lady { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IClub Club { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
