using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament.Contracts.EntitiesDB
{
    public class Match : EntityBaseDB
    {
        public int GuestScore { get; set; }
        public int HomeScore { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("HomePlayerId")]
        public virtual Player HomePlayer { get; set; }
        [ForeignKey("HomeTeamId")]
        public virtual Team HomeTeam { get; set; }
        [ForeignKey("GuestPlayerId")]
        public virtual Player GuestPlayer { get; set; }
        [ForeignKey("GuestTeamId")]
        public virtual Team GuestTeam { get; set; }
        [ForeignKey("CompetitionId")]
        public virtual Competition Competition { get; set; }
    }
}
