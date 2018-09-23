using System;
using System.Linq;
using RickAndMorty.Net.Api.Factory;
using RickAndMorty.Net.Api.Models.Enums;
using RickAndMorty.Net.Api.Service;
using Xunit;

namespace RickAndMorty.Net.Api.Tests
{
    public class ServiceTests
    {
        //TODO: comments

        private IRickAndMortyService RickAndMortyService { get; }

        public ServiceTests()
        {
            RickAndMortyService = RickAndMortyApiFactory.Create();
        }

        [Theory]
        [InlineData(6)]
        public async void GetCharacterTest(int value)
        {
            var result = await RickAndMortyService.GetCharacter(value);

            Assert.NotNull(result);
            Assert.True(result.Id == value);
            Assert.True(!String.IsNullOrEmpty(result.Name));
            Assert.True(!String.IsNullOrEmpty(result.Species));
            Assert.True(result.Created != default(DateTime));
            Assert.NotEmpty(result.Episode);
        }

        [Fact]
        public async void GetAllCharactersTest()
        {
            var result = await RickAndMortyService.GetAllCharacters();

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Species));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Episode);
        }

        [Theory]
        [InlineData(new[] {5, 10})]
        public async void GetMultipleCharactersTest(int[] value)
        {
            var result = await RickAndMortyService.GetMultipleCharacters(value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Species));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Episode);
        }

        [Theory]
        [InlineData(CharacterStatus.Alive)]
        public async void FilterCharactersTest(CharacterStatus value)
        {
            var result = await RickAndMortyService.FilterCharacters(characterStatus: value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Species));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Episode);
        }

        [Fact]
        public async void GetAllLocationsTest()
        {
            var result = await RickAndMortyService.GetAllLocations();

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Dimension));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Residents);
        }

        [Theory]
        [InlineData(new[] { 5, 10 })]
        public async void GetMultipleLocationsTest(int[] value)
        {
            var result = await RickAndMortyService.GetMultipleLocations(value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Dimension));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Residents);
        }

        [Theory]
        [InlineData(6)]
        public async void GetLocationTest(int value)
        {
            var result = await RickAndMortyService.GetLocation(value);

            Assert.NotNull(result);
            Assert.True(result.Id == value);
            Assert.True(!String.IsNullOrEmpty(result.Name));
            Assert.True(!String.IsNullOrEmpty(result.Dimension));
            Assert.True(result.Created != default(DateTime));
            Assert.NotEmpty(result.Residents);
        }

        [Theory]
        [InlineData("earth")]
        public async void FilterLocationsTest(string value)
        {
            var result = await RickAndMortyService.FilterLocations(value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().Dimension));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Residents);
        }

        [Fact]
        public async void GetAllEpisodesTest()
        {
            var result = await RickAndMortyService.GetAllEpisodes();

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().EpisodeCode));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Characters);
        }

        [Theory]
        [InlineData(5)]
        public async void GetEpisodeTest(int value)
        {
            var result = await RickAndMortyService.GetEpisode(value);

            Assert.NotNull(result);
            Assert.True(result.Id == value);
            Assert.True(!String.IsNullOrEmpty(result.Name));
            Assert.True(!String.IsNullOrEmpty(result.EpisodeCode));
            Assert.True(result.Created != default(DateTime));
            Assert.NotEmpty(result.Characters);
        }

        [Theory]
        [InlineData(new[] { 5, 10 })]
        public async void GetMultipleEpisodesTest(int[] value)
        {
            var result = await RickAndMortyService.GetMultipleEpisodes(value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().EpisodeCode));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Characters);
        }

        [Theory]
        [InlineData("Rick")]
        public async void FilterEpisodesTest(string value)
        {
            var result = await RickAndMortyService.FilterEpisodes(name:value);

            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.True(!String.IsNullOrEmpty(result.First().Name));
            Assert.True(!String.IsNullOrEmpty(result.First().EpisodeCode));
            Assert.True(result.First().Created != default(DateTime));
            Assert.NotEmpty(result.First().Characters);
        }
    }
}
