namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IRound
    {
        IList<ICouple> QualifiedCouples { get; set; }
    }
}