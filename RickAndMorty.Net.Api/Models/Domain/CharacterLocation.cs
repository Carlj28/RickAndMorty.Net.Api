using System;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class CharacterLocation
    {
        /// <summary>
        /// Name to the character's last known location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's last known location.
        /// </summary>
        public Uri Url { get; set; }
    }
}
