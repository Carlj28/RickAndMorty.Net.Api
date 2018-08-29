using System.Collections.Generic;

namespace RickAndMorty.Net.Api.Models.Dto
{
    public class PageDto<T>
    {
        public PageInfoDto Info { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
