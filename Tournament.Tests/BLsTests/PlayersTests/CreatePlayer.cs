//using Moq;
//using System.Threading.Tasks;
//using Tournament.BL;
//using Tournament.Contracts.Commons.Exceptions;
//using Tournament.Tests.MockEntitiesCreators.Players;
//using Xunit;

//namespace Tournament.Tests.BLsTests.PlayersTests
//{
//    public class CreatePlayer : TournamentBaseBLTest
//    {
//        private readonly PlayersBL _playerBL;
//        public CreatePlayer() : base()
//        {
//            _playerBL = new PlayersBL(_playerRepositoryMock.Object);
//        }

//        [Fact]
//        public async Task CreatePlayer_Success()
//        {
//            MockPlayerFindBy();
//            MockPlayerCreatePlayer();

//            var playerRequest = PlayerMockRequestCreator.CreatePlayerRequest();
//            var playerToSave = PlayerMockCreator.CreateMockPlayerOnDB();

//            await _playerBL.CreatePlayer(playerRequest);

//            _playerRepositoryMock.Verify(x => x.Create(playerToSave), Times.Once);
//        }

//        [Fact]
//        public async Task CreatePlayer_Fail_Username_Duplicate()
//        {
//            MockPlayerGetById();

//            var playerRequest = PlayerMockRequestCreator.CreatePlayerRequest();
//            var playerToSave = PlayerMockCreator.CreateMockPlayerOnDB();

//            Task result() => _playerBL.CreatePlayer(playerRequest);

//            var exception = await Assert.ThrowsAsync<DataNotValidException>(result);
//            Assert.Equal("Username already in exists.", exception.Message);
//        }
//    }
//}
