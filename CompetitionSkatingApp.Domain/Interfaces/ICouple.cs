namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface ICouple
    {
        IPerson Man { get; set; }
        IPerson Lady { get; set; }
        IClub Club { get; set; }
    }
}