using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface ICompetition
    {
        string Name { get; set; }
        Discipline Discipline { get; set; }
        int AmountOfDances { get; set; }
        AgeCategory AgeCategory { get; set; }
        IList<IOfficial> Adjudicators { get; set; }
        IOfficial Chairperson { get; set; }
        IList<ICouple> Couples { get; set; }
        IList<IRound> Rounds { get; set; }

    }
}
