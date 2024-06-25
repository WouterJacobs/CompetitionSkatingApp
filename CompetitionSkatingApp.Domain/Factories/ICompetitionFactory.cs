using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain.Factories;

public interface ICompetitionFactory
{
    public ICompetition CreateCompetition(string name, Discipline discipline, int amountOfDances,
        AgeCategory ageCategory, IOfficial chairperson);
}