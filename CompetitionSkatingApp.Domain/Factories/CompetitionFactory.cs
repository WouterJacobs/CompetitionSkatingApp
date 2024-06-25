using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain.Factories
{
    public class CompetitionFactory
    {
        static Competition CreateCompetition(string name, Discipline discipline, int amountOfDances,
            AgeCategory ageCategory, Chairman chairperson)
        {
            Competition competition = new Competition(name, discipline, amountOfDances, ageCategory, chairperson);
            return competition;
        }
    }
}
