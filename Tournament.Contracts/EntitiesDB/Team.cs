using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament.Contracts.EntitiesDB
{
    public class Team : EntityBaseDB
    {
        public string Name { get; set; }

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Match> HomeMatches { get; set; }
        [InverseProperty("GuestTeam")]
        public virtual ICollection<Match> GuestMatches { get; set; }
    }
}
