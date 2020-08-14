//using Moq;
//using System;
//using System.Linq;
//using System.Linq.Expressions;
//using Tournament.Contracts.DTOs.Commons;
//using Tournament.Contracts.EntitiesDB;
//using Tournament.DB.Interfaces;
//using Tournament.Tests.MockEntitiesCreators.Players;

//namespace Tournament.Tests.BLsTests
//{
//    public class TournamentBaseBLTest
//    {
//        protected readonly Mock<IPlayerRepository> _playerRepositoryMock = new Mock<IPlayerRepository>();

//        public TournamentBaseBLTest()
//        {
//        }

//        protected void MockPlayerGetById()
//        {
//            var playerDB = PlayerMockCreator.CreateMockPlayerOnDB();
//            _playerRepositoryMock.Setup(x => x.GetById(playerDB.Id))
//                .ReturnsAsync(playerDB);
//        }

//        protected void MockPlayerFindBy()
//        {
//            //var playerListDB = PlayerMockCreator.CreateMockListPlayersOnDB();
//            var playerListDB = Enumerable.Empty<Player>().AsQueryable();

//            _playerRepositoryMock.As<IQueryable<Player>>().Setup(m => m.Expression).Returns(playerListDB.Expression);
//            _playerRepositoryMock.As<IQueryable<Player>>().Setup(m => m.ElementType).Returns(playerListDB.ElementType);
//            _playerRepositoryMock.As<IQueryable<Player>>().Setup(m => m.GetEnumerator()).Returns(playerListDB.GetEnumerator());
//            //_playerRepositoryMock.Setup(x => x.FindBy(expression))
//            //    .ReturnsAsync(playerListDB.FirstOrDefault());
//        }

//        protected void MockPlayerCreatePlayer()
//        {
//            var playerDB = PlayerMockCreator.CreateMockPlayerToSave();
//            _playerRepositoryMock.Setup(x => x.Create(playerDB));
//        }

//        protected void SetupMockEmptyData()
//        {
//            _playerRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
//               .ReturnsAsync(() => null);
//        }
//    }
//}
