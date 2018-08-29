using AutoMapper;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Models.Dto;

namespace RickAndMorty.Net.Api.Mapper
{
    public class MapperModule
    {
        public static IMapper Resolve()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CharacterLocation, CharacterDto>().ReverseMap();

                cfg.CreateMap<CharacterOrigin, CharacterOriginDto>().ReverseMap();

                cfg.CreateMap<Character, CharacterDto>().ReverseMap();

                cfg.AllowNullCollections = true;
            });

            return config.CreateMapper();
        }
    }
}
