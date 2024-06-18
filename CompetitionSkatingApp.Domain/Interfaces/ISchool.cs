namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface ISchool
    {
        string Name { get; set; }
        IAddress Address { get; set; }
        string Owner { get; set; }
    }
}