using RickAndMorty.Net.Api.Helpers;
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
    }
}
