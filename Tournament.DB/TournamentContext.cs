using Microsoft.EntityFrameworkCore;
using Tournament.Contracts.EntitiesDB;
using Tournament.DB.Configs;

namespace Tournament.DB
{
    public class TournamentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Settings.GetDBConnectionString() return the string to connect to DB
            optionsBuilder.UseSqlServer(Settings.GetDBConnectionString());
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Competition> Competitions { get; set; }
    }
}
