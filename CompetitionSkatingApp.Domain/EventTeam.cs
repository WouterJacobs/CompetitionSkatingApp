using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class EventTeam : IEventTeam
    {
        public IEventCoordinator Organizer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEventCoordinator MasterOfCeremony { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IOfficial> Chairman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEventCoordinator Diskjockey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IEventCoordinator> Scrutineers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
