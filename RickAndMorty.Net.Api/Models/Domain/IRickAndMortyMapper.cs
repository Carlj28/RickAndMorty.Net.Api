using AutoMapper;

namespace RickAndMorty.Net.Api.Models.Domain
{
    internal interface IRickAndMortyMapper
    {
        IMapper Mapper { get; set; }
    }
}
