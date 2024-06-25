using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain.Factories
{
    public class EventFactory : IEventFactory
    {
        public IDancingEvent CreateEvent(string name, DateOnly startDate, DateOnly endDate, IEventLocation location, IEventSchool school,
            string description, IEventTeam eventTeam)
        {
            DancingEvent dancingEvent = new DancingEvent(name, startDate, endDate, location, school, description, eventTeam);
            return dancingEvent;
        }
    }
}
