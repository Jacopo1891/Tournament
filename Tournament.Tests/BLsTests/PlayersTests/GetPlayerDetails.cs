//using System.Threading.Tasks;
//using Tournament.BL;
//using Tournament.Contracts.Commons.Exceptions;
//using Tournament.Tests.MockEntitiesCreators.Players;
//using Xunit;
//using Requests = Tournament.Contracts.DTOs.Players.Requests;

//namespace Tournament.Tests.BLsTests.PlayersTests
//{
//    public class GetPlayerDetails : TournamentBaseBLTest
//    {
//        private readonly PlayersBL _playerBL;
//        public GetPlayerDetails() : base()
//        {
//            _playerBL = new PlayersBL(_playerRepositoryMock.Object);
//        }

//        [Fact]
//        public async Task GetPlayerDetails_Player_Exists()
//        {
//            MockPlayerGetById();
//            var playerDB = PlayerMockCreator.CreateMockPlayerOnDB();

//            var playerDTO = await _playerBL.GetPlayerDetails(new Requests.GetPlayerDetailsRequest { Id = playerDB.Id });

//            Assert.Equal(playerDB.Id, playerDTO.Id);
//            Assert.Equal(playerDB.Name, playerDTO.Name);
//            Assert.Equal(playerDB.Lastname, playerDTO.Lastname);
//            Assert.Equal(playerDB.Username, playerDTO.Username);
//            Assert.Equal(playerDB.LastEdit, Tournament.Utilities.Converters.DataTimeConverter.GetDateTime(playerDTO.LastEdit));
//        }

//        [Fact]
//        public async Task GetPlayerDetails_Player_DoesNotExist()
//        {
//            SetupMockEmptyData();

//            Task result() => _playerBL.GetPlayerDetails(new Requests.GetPlayerDetailsRequest { Id = Tournament.Utilities.Numbers.RandomGenerator.GetNumber() });
//            var exception = await Assert.ThrowsAsync<EntityNotFoundException>(result);
//            Assert.Equal("Player not found.", exception.Message);
//        }
//    }
//}
