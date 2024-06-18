namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IEventSchool : IClub
    {
        string Owner { get; set; }
    }
}