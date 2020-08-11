using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tournament.Contracts.EntitiesDB;
using Tournament.DB.Interfaces;

namespace Tournament.DB.Repositories
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public override Task<Player> GetById(int id) => _TournamentContext.Players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
    }
}
