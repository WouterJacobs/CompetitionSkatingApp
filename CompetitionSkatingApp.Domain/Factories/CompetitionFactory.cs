using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain.Factories
{
    public class CompetitionFactory : ICompetitionFactory
    {
        public ICompetition CreateCompetition(string name, Discipline discipline, int amountOfDances,
            AgeCategory ageCategory, IOfficial chairperson)
        {
            Competition competition = new Competition(name, discipline, amountOfDances, ageCategory, chairperson);
            return competition;
        }
    }
}
