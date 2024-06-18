using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain.Interfaces
{
    public interface IEvent
    {
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public IEventLocation Location { get; set; } 
        public ISchool School { get; set; }
        public string Description { get; set; }
        public IEventTeam EventTeam { get; set; }
        public IList<ICompetition> Competitions { get; set; }
    }
}
