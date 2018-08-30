using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnsureThat;
using RickAndMorty.Net.Api.Helpers;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Models.Dto;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Service
{
    public class RickAndMortyService : BaseService, IRickAndMortyService
    {
        public RickAndMortyService(IMapper mapper, string baseAddress = "https://rickandmortyapi.com/") : base(mapper, baseAddress)
        {
        }

        public async Task<Character> GetCharacter(int id)
        {
            Ensure.Bool.IsTrue(id > 0);

            var dto = await Get<CharacterDto>($"api/character/{id}");

            return Mapper.Map<Character>(dto);
        }

        public async Task<IEnumerable<Character>> GetAllCharacters()
        {
            var dto = await GetPages<CharacterDto>("api/character/");

            return Mapper.Map<IEnumerable<Character>>(dto);
        }

        public async Task<IEnumerable<Character>> GetMultipleCharacters(int[] ids)
        {
            Ensure.Bool.IsTrue(ids.Any());

            var dto = await Get<IEnumerable<CharacterDto>>($"api/character/{string.Join(",", ids)}");

            return Mapper.Map<IEnumerable<Character>>(dto);
        }

        public async Task<IEnumerable<Character>> FilterCharacters(string name = "",
            CharacterStatus? characterStatus = null,
            string species = "",
            string type = "",
            CharacterGender? gender = null)
        {
            Ensure.Bool.IsTrue(!String.IsNullOrEmpty(name) || characterStatus != null ||
                               !String.IsNullOrEmpty(species) || !String.IsNullOrEmpty(type) || gender != null);

            var url = "/api/character/".BuildCharacterFilterUrl(name, characterStatus, species, type, gender);

            var dto = await GetPages<CharacterDto>(url);

            return Mapper.Map<IEnumerable<Character>>(dto);
        }

        public async Task<IEnumerable<Location>> GetAllLocations()
        {
            var dto = await GetPages<LocationDto>("api/location/");

            return Mapper.Map<IEnumerable<Location>>(dto);
        }

        public async Task<IEnumerable<Location>> GetMultipleLocations(int[] ids)
        {
            Ensure.Bool.IsTrue(ids.Any());

            var dto = await Get<IEnumerable<LocationDto>>($"api/location/{string.Join(",", ids)}");

            return Mapper.Map<IEnumerable<Location>>(dto);
        }

        public async Task<Location> GetLocation(int id)
        {
            Ensure.Bool.IsTrue(id > 0);

            var dto = await Get<LocationDto>($"api/location/{id}");

            return Mapper.Map<Location>(dto);
        }

        public async Task<IEnumerable<Location>> FilterLocations(string name = "",
            string type = "",
            string dimension = "")
        {
            Ensure.Bool.IsTrue(!String.IsNullOrEmpty(name) || !String.IsNullOrEmpty(type) || !String.IsNullOrEmpty(dimension));

            var url = "/api/location/".BuildLocationFilterUrl(name, type, dimension);

            var dto = await GetPages<LocationDto>(url);

            return Mapper.Map<IEnumerable<Location>>(dto);
        }
    }
}
