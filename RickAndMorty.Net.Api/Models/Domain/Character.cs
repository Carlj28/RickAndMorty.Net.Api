using System;
using System.Collections.Generic;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public CharacterLocation Location { get; set; }
        public CharacterOrigin Origin { get; set; }
        public string Image { get; set; }
        public IEnumerable<string> Episode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
