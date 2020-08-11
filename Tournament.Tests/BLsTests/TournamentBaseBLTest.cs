using Moq;
using Tournament.DB.Interfaces;
using Tournament.Tests.MockEntitiesCreators;

namespace Tournament.Tests.BLsTests
{
    public class TournamentBaseBLTest
    {
        protected readonly Mock<IPlayerRepository> _playerRepositoryMock = new Mock<IPlayerRepository>();

        public TournamentBaseBLTest()
        {
            SetupMockDataAsync();
        }

        protected void SetupMockDataAsync()
        {
            var playerDTO = PlayerMockCreator.CreateMockPlayer();
            _playerRepositoryMock.Setup(x => x.GetById(playerDTO.Id))
                .ReturnsAsync(playerDTO);
        }

        protected void SetupMockEmptyData()
        {
            _playerRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
               .ReturnsAsync(() => null);
        }
    }
}
