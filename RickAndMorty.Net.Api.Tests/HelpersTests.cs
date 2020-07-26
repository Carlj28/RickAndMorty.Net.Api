using RickAndMorty.Net.Api.Helpers;
using RickAndMorty.Net.Api.Models.Enums;
using System;
using Xunit;

namespace RickAndMorty.Net.Api.Tests
{
    public class HelpersTests
    {
        [Fact]
        public void GetNextPageHelperTest()
        {
            var url = "https://rickandmortyapi.com/api/character/?page=2";

            var result = url.GetNextPageNumber();

            Assert.True(result > 0);
        }

        [Fact]
        public void BuildCharacterFilterUrlTest()
        {
            var url = "/api/character/".BuildCharacterFilterUrl(name: "TestName", status: CharacterStatus.Alive,
                species: "TestSpecie", type: "TestType", gender: CharacterGender.Female);

            Assert.Equal("/api/character/?name=TestName&status=Alive&species=TestSpecie&type=TestType&gender=Female", url);
        }

        [Fact]
        public void BuildLocationUrlTest()
        {
            var url = "/api/location/".BuildLocationFilterUrl(name: "TestName", type: "TestType",
                dimension: "TestDimension");

            Assert.Equal("/api/location/?name=TestName&type=TestType&dimension=TestDimension", url);
        }

        [Fact]
        public void ToUriMapperHelpers()
        {
            var url = "https://rickandmortyapi.com/api/location/6";

            Assert.NotNull(url.ToUri());
        }
    }
}
