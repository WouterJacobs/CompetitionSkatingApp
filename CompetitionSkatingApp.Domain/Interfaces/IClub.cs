namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IClub
    {
        string Name { get; set; }
        IAddress Address { get; set; }
    }
}