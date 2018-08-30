using System.Linq;
using RickAndMorty.Net.Api.Mapper;
using RickAndMorty.Net.Api.Models.Enums;
using RickAndMorty.Net.Api.Service;
using Xunit;

namespace RickAndMorty.Net.Api.Tests
{
    public class ServiceTests
    {
        //TODO: not only happy path tests
        //TODO: check more conditions in assert
        //TODO: comments

        private readonly IRickAndMortyService RickAndMortyService;

        public ServiceTests()
        {
            RickAndMortyService = new RickAndMortyService(MapperModule.Resolve());
        }

        [Fact]
        public async void GetCharacterTest()
        {
            var result = await RickAndMortyService.GetCharacter(5);

            Assert.NotNull(result);
            Assert.True(result.Id == 5);
        }

        [Fact]
        public async void GetAllCharactersTest()
        {
            var result = await RickAndMortyService.GetAllCharacters();

            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetMultipleCharactersTest()
        {
            var result = await RickAndMortyService.GetMultipleCharacters(new []{5, 10});

            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void FilterCharactersTest()
        {
            var result = await RickAndMortyService.FilterCharacters(characterStatus: CharacterStatus.Alive);

            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetAllLocationsTest()
        {
            var result = await RickAndMortyService.GetAllLocations();

            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetMultipleLocationsTest()
        {
            var result = await RickAndMortyService.GetMultipleLocations(new [] {5, 10});

            Assert.NotNull(result);
            Assert.True(result.Any());
        }

        [Fact]
        public async void GetLocationTest()
        {
            var result = await RickAndMortyService.GetLocation(5);

            Assert.NotNull(result);
            Assert.True(result.Id == 5);
        }

        [Fact]
        public async void FilterLocationsTest()
        {
            var result = await RickAndMortyService.FilterLocations("earth");

            Assert.NotNull(result);
            Assert.True(result.Any());
        }
    }
}
