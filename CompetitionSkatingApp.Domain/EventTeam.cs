using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    public class EventTeam : IEventTeam
    {
        private IEventCoordinator _organizer;
        private IEventCoordinator _masterOfCeremony;
        private IList<IOfficial> _chairmans;
        private IEventCoordinator _diskjockey;
        private IList<IEventCoordinator> _scrutineers;

        public EventTeam(IEventCoordinator organizer, IEventCoordinator masterOfCeremony,
            IEventCoordinator diskjockey)
        {
            _organizer = organizer ?? throw new ArgumentNullException(nameof(organizer));
            _masterOfCeremony = masterOfCeremony ?? throw new ArgumentNullException(nameof(masterOfCeremony));
            _diskjockey = diskjockey ?? throw new ArgumentNullException(nameof(diskjockey));
            _chairmans = new List<IOfficial>();
            _scrutineers = new List<IEventCoordinator>();
        }

        public IEventCoordinator Organizer
        {
            get => _organizer;
            set => _organizer = value;
        }

        public IEventCoordinator MasterOfCeremony
        {
            get => _masterOfCeremony;
            set => _masterOfCeremony = value;
        }

        public IList<IOfficial> Chairmans
        {
            get => _chairmans;
            set => _chairmans = value;
        }

        public IEventCoordinator Diskjockey
        {
            get => _diskjockey;
            set => _diskjockey = value;
        }

        public IList<IEventCoordinator> Scrutineers
        {
            get => _scrutineers;
            set => _scrutineers = value;
        }
        
        //TODO add a good tostring

        public void AddChairman(IOfficial chairman)
        {
            _chairmans.Add(chairman);
        }
        public void AddScrutineer(IEventCoordinator scrutineer)
        {
            _scrutineers.Add(scrutineer);
        }
    }
}
