namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IAddress
    {
        string Country { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string Street { get; set; }
        int Number { get; set; }
    }
}