using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tournament.DB
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task Create(T entity);

        Task Update(int id, T entity);

        Task Delete(int id);

        Task Save();
    }
}
