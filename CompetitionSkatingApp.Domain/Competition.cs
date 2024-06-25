using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Competition : ICompetition
    {
        private string _name;
        private Discipline _discipline;
        private int _amountOfDances;
        private AgeCategory _ageCategory;
        private IList<IOfficial> _adjudicators;
        private IOfficial _chairperson;
        private IList<ICouple> _couples;
        private IList<IRound> _rounds;

        internal Competition(string name, Discipline discipline, int amountOfDances, AgeCategory ageCategory, IOfficial chairperson)
        {
            _name = name;
            _discipline = discipline;
            _amountOfDances = amountOfDances;
            _ageCategory = ageCategory;
            _chairperson = chairperson;
            _adjudicators = new List<IOfficial>();
            _couples = new List<ICouple>();
            _rounds = new List<IRound>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Discipline Discipline
        {
            get => _discipline;
            set => _discipline = value;
        }

        public int AmountOfDances
        {
            get => _amountOfDances;
            set => _amountOfDances = value;
        }

        public AgeCategory AgeCategory
        {
            get => _ageCategory;
            set => _ageCategory = value;
        }

        public IList<IOfficial> Adjudicators
        {
            get => _adjudicators;
            set => _adjudicators = value;
        }

        public IOfficial Chairperson
        {
            get => _chairperson;
            set => _chairperson = value;
        }

        public IList<ICouple> Couples
        {
            get => _couples;
            set => _couples = value;
        }

        public IList<IRound> Rounds
        {
            get => _rounds;
            set => _rounds = value;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Discipline: {_discipline}, AmountOfDances: {_amountOfDances}, AgeCategory: {_ageCategory}, " +
                   $"Adjudicators: {_adjudicators.Count}, Chairperson: {_chairperson}, Couples: {_couples.Count}, " +
                   $"Rounds: {_rounds.Count}";
        }

        public void AddAdjudicator(IOfficial adjudicator)
        {
            _adjudicators.Add(adjudicator);
        }
        public void AddCouple(ICouple couple)
        {
            _couples.Add(couple);
        }
        public void AddRound(IRound round)
        {
            _rounds.Add(round);
        }
        
    }
}
