using AutoMapper;

namespace RickAndMorty.Net.Api.Models.Domain
{
    internal class RickAndMortyMapper : IRickAndMortyMapper
    {
        public IMapper Mapper { get; set; }
    }
}
