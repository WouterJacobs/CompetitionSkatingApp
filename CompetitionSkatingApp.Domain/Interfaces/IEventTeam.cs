namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IEventTeam
    {
        public IEventCoordinator Organizer { get; set; }
        public IEventCoordinator MasterOfCeremony { get; set; }
        public IList<IOfficial> Chairman { get; set; }
        public IEventCoordinator Diskjockey { get; set; }
        public IList<IEventCoordinator> Scrutineers { get; set; }

    }
}