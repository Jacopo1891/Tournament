using Tournament.Contracts.DTOs.Players.Requests;

namespace Tournament.Tests.MockEntitiesCreators.Players
{
    public class PlayerMockRequestCreator
    {
        public static CreatePlayerRequest CreatePlayerRequest()
        {
            return new CreatePlayerRequest
            {
                Username = "Jacopo1891",
                Name = "Jacopo",
                Lastname = "Campani"
            };
        }
    }
}
