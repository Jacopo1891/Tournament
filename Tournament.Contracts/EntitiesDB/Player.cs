using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament.Contracts.EntitiesDB
{
    public class Player : EntityBaseDB
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Registration { get; set; }

        [InverseProperty("HomePlayer")]
        public virtual ICollection<Match> HomeMatches { get; set; }
        [InverseProperty("GuestPlayer")]
        public virtual ICollection<Match> GuestMatches { get; set; }
    }
}
