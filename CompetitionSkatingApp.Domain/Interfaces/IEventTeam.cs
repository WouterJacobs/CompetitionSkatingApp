namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IEventTeam
    {
        public EventCoordinator Organizer { get; set; }
        public EventCoordinator MasterOfCeremony { get; set; }
        public IList<IOfficial> Chairman { get; set; }
        public EventCoordinator Diskjockey { get; set; }
        public IList<EventCoordinator> Scrutineers { get; set; }

    }
}