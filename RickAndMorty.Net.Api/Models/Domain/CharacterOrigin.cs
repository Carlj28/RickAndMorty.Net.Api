using System;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class CharacterOrigin
    {
        /// <summary>
        /// Name to the character's origin location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's origin location.
        /// </summary>
        public Uri Url { get; set; }
    }
}
