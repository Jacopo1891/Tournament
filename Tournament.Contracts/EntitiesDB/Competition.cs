using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tournament.Contracts.EntitiesDB.Enums;

namespace Tournament.Contracts.EntitiesDB
{
    public class Competition : EntityBaseDB
    {
        public TournamentType Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
       
        [InverseProperty("Competition")]
        public virtual ICollection<Match> Matches { get; set; }
    }
}
