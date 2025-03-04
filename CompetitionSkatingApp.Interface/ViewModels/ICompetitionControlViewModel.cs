﻿using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Interface.ViewModels
{
    public interface ICompetitionControlViewModel
    {
        public string EventName { get; set; }
        public IDancingEvent DancingEvent { get; set; }
        public bool CanAddCompetition { get; set; }
        public void CreateNewEvent(string eventName);
        public void AddCompetitionToEvent(string competition);
        public void UpdateEventDetails();

        public void LoadDancingEvent(string path);

    }
}
