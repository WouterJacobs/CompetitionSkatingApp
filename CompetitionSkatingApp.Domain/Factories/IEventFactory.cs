using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain.Factories;

public interface IEventFactory
{
    IDancingEvent CreateEvent(string name, DateOnly startDate, DateOnly endDate, IEventLocation location, IEventSchool school,
        string description, IEventTeam eventTeam);
}