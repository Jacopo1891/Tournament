
using Tournament.Contracts.Commons;

namespace Tournament.Contracts.DTOs.Commons
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public string LastEdit { get; set; }
    }
}
