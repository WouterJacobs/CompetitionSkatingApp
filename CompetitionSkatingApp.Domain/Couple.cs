using CompetitionSkatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionSkatingApp.Domain
{
    internal class Couple : ICouple
    {
        private IPerson _man;
        private IPerson _lady;
        private IClub _club;

        internal Couple(IPerson man, IPerson lady, IClub club)
        {
            _man = man ?? throw new ArgumentNullException(nameof(man));
            _lady = lady ?? throw new ArgumentNullException(nameof(lady));
            _club = club ?? throw new ArgumentNullException(nameof(club));
        }

        public IPerson Man
        {
            get => _man;
            set => _man = value;
        }

        public IPerson Lady
        {
            get => _lady;
            set => _lady = value;
        }

        public IClub Club
        {
            get => _club;
            set => _club = value;
        }

        public override string ToString()
        {
            return $"Man: {_man.FirstName} {_man.LastName}, Lady: {_lady.FirstName} {_lady.LastName}, Club: {_club.Name}";
        }
    }
}
