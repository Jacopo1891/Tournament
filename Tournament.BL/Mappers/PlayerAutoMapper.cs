using AutoMapper;
using Tournament.Contracts.DTOs.Players.Requests;
using Tournament.Contracts.DTOs.Players.Responses;
using Tournament.Contracts.EntitiesDB;

namespace Tournament.BL.Mappers
{
    public class PlayerAutoMapper
    {
        public IMapper mapper;
        public PlayerAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Player, GetPlayerDetailsDTO>()
                                .ForMember(dest => dest.LastEdit, opt =>
                                    opt.MapFrom(src => Utilities.Converters.DataTimeConverter.GetString(src.LastEdit)))
                                .ForSourceMember(src => src.GuestMatches, dest => dest.DoNotValidate())
                                .ForSourceMember(src => src.HomeMatches, dest => dest.DoNotValidate())
                                .ForSourceMember(src => src.Registration, dest => dest.DoNotValidate());

                cfg.CreateMap<CreatePlayerRequest, Player>();
            });

            this.mapper = config.CreateMapper();
        }
    }
}
