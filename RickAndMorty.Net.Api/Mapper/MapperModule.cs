using System;
using System.Linq;
using AutoMapper;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Models.Dto;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Mapper
{
    internal class MapperModule
    {
        public static IMapper Resolve()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CharacterLocationDto, CharacterLocation>()
                    .ForMember(dest => dest.Url,
                        opts => opts.MapFrom(src => new Uri(src.Url)));

                cfg.CreateMap<CharacterOriginDto, CharacterOrigin>()
                    .ForMember(dest => dest.Url,
                        opts => opts.MapFrom(src => new Uri(src.Url)));

                cfg.CreateMap<CharacterDto, Character>()
                    .ForMember(dest => dest.Status,
                        opts => opts.MapFrom(src => Enum.Parse(typeof(CharacterStatus), src.Status)))
                    .ForMember(dest => dest.Gender,
                        opts => opts.MapFrom(src => Enum.Parse(typeof(CharacterGender), src.Gender)))
                    .ForMember(dest => dest.Image,
                        opts => opts.MapFrom(src => new Uri(src.Image)))
                    .ForMember(dest => dest.Episode,
                        opts => opts.MapFrom(src => src.Episode.Select(e => new Uri(e))))
                    .ForMember(dest => dest.Url,
                        opts => opts.MapFrom(src => new Uri(src.Url)));


                cfg.CreateMap<LocationDto, Location>();

                cfg.CreateMap<EpisodeDto, Episode>()
                    .ForMember(dest => dest.AirDate,
                        opts => opts.MapFrom(src => src.Air_date))
                    .ForMember(dest => dest.EpisodeCode,
                        opts => opts.MapFrom(src => src.Episode));

                cfg.AllowNullCollections = true;
            });

            return config.CreateMapper();
        }
    }
}
