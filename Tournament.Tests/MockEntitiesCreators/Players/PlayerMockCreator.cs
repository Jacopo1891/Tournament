using System;
using System.Collections.Generic;
using System.Linq;
using Tournament.Contracts.EntitiesDB;
using Tournament.Tests.BLsTests.PlayersTests;

namespace Tournament.Tests.MockEntitiesCreators.Players
{
    public class PlayerMockCreator
    {
        private static List<Player> players;

        public static Player CreateMockPlayerOnDB()
        {
            if (players == null)
                players = CreateMockListPlayersOnDB();

            return players.FirstOrDefault();
        }

        public static Player CreateMockPlayerToSave()
        {
            return CreatePlayer(null, "Jacopo", "Campani", "Jacopo1891");
        }

        public static List<Player> CreateMockListPlayersOnDB()
        {
            var player1 = CreatePlayer(1, "Jacopo", "Campani", "Jacopo1891");
            var player2 = CreatePlayer(1, "Jacopo", "Campani", "Jacopo1891");
            var player3 = CreatePlayer(1, "Jacopo", "Campani", "Jacopo1891");

            return new List<Player> { player1, player2, player3 };
        }

        private static Player CreatePlayer(int? pId, string pName, string pLastname, string pUsername)
        {
            DateTime now = DateTime.Now;
            var nowWithoutMilliseconds = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            var pLastEdit = nowWithoutMilliseconds;
            var playerRegistration = nowWithoutMilliseconds;

            return new Player
            {
                Id = pId.HasValue ? pId.Value : 0,
                Name = pName,
                Lastname = pLastname,
                Username = pUsername,
                LastEdit = pLastEdit,
                Registration = playerRegistration
            };
        }
    }
}
