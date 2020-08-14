using System;
using System.Threading.Tasks;
using Tournament.BL.Mappers;
using Tournament.Contracts.Commons.Enums;
using Tournament.Contracts.Commons.Exceptions;
using Tournament.Contracts.Commons.Messages;
using Tournament.Contracts.DTOs.Commons;
using Tournament.Contracts.DTOs.Players.Requests;
using Tournament.Contracts.DTOs.Players.Responses;
using Tournament.Contracts.EntitiesDB;
using Tournament.DB.Interfaces;

namespace Tournament.BL
{
    public class PlayerBL : TournamentBL
    {
        private PlayerAutoMapper mapperPlayer;
        public PlayerBL(IPlayerRepository playerRepository)
        {
            this.PlayerRepository = playerRepository;
            this.mapperPlayer = new PlayerAutoMapper();
        }

        public async Task CreatePlayer(CreatePlayerRequest request)
        {
            var usernameAlreadyExists = await CheckUsernameAlreadyExistsAsync(request.Username);
            if (usernameAlreadyExists)
                throw new DataNotValidException(ErrorMessages.UsernameAlreadyExists());

            await PlayerRepository.Create(mapperPlayer.mapper.Map<Player>(request));
        }

        public async Task<GetPlayerDetailsDTO> GetPlayerDetails(GetPlayerDetailsRequest request)
        {
            var playerDB = await PlayerRepository.GetById(request.Id);
            if (playerDB == null)
                throw new EntityNotFoundException(ErrorMessages.EntityNotFound(Entities.PLAYER));
            return mapperPlayer.mapper.Map<GetPlayerDetailsDTO>(playerDB);
        }

        private async Task<bool> CheckUsernameAlreadyExistsAsync(string username)
        {
            bool exists = false;
            var playerDB = await PlayerRepository.FindBy(p => p.Username == username);
            if (playerDB != null)
                exists = true;

            return exists;
        }
    }
}
