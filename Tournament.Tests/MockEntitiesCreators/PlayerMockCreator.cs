using System;
using Tournament.Contracts.EntitiesDB;

namespace Tournament.Tests.MockEntitiesCreators
{
    public class PlayerMockCreator
    {
        private static Player player;
        public static Player CreateMockPlayer()
        {
            if (player != null)
                return player;

            DateTime now = DateTime.Now;
            var nowWithoutMilliseconds = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            var playerId = 1;
            var playerName = "Jacopo";
            var playerLastname = "Campani";
            var playerUsername = "Jacopo1891";
            var playerLastEdit = nowWithoutMilliseconds;
            var playerRegistration = nowWithoutMilliseconds;

            player = new Player
            {
                Id = playerId,
                Name = playerName,
                Lastname = playerLastname,
                Username = playerUsername,
                LastEdit = playerLastEdit,
                Registration = playerRegistration
            };
            return player;
        }
    }
}
