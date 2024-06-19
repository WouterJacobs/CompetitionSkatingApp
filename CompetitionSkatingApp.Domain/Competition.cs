using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Competition : ICompetition
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Discipline Discipline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AmountOfDances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AgeCategory AgeCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IOfficial> Adjudicators { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOfficial Chairperson { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<ICouple> Couples { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IRound> Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
