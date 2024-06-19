using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Event : IEvent
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateOnly StartDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateOnly EndDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEventLocation Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEventSchool School { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEventTeam EventTeam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<ICompetition> Competitions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
