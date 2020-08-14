using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tournament.DB
{

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly TournamentContext _TournamentContext;
        public GenericRepository()
        {
            _TournamentContext = new TournamentContext();
        }

        public async Task Create(TEntity entity)
        {
            await _TournamentContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task Update(int id, TEntity entity)
        {
            _TournamentContext.Set<TEntity>().Update(entity);
            await _TournamentContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _TournamentContext.Set<TEntity>().Remove(entity);
            await _TournamentContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _TournamentContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            await _TournamentContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> FindBy(Expression<Func<TEntity, bool>> expression)
        {
            return await _TournamentContext.Set<TEntity>()
                        .Where(expression).AsNoTracking().ToListAsync();
        }
    }
}
