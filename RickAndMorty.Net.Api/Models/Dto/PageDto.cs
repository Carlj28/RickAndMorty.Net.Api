using System.Collections.Generic;

namespace RickAndMorty.Net.Api.Models.Dto
{
    internal class PageDto<T>
    {
        public PageInfoDto Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
