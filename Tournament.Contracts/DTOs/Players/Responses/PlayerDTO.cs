using Tournament.Contracts.Commons;

namespace Tournament.Contracts.DTOs.Players.Responses
{
    public class PlayerDTO : PlayerDTOBase, IEntityBase
    {
        public int Id { get; set; }
        public string LastEdit { get; set; }
    }
}
