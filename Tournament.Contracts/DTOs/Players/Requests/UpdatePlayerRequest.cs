using Tournament.Contracts.Commons;

namespace Tournament.Contracts.DTOs.Players.Requests
{
    public class UpdatePlayerRequest : CreatePlayerRequest, IEntityBase
    {
        public int Id { get; set; }
        public string LastEdit { get; set; }
    }
}
