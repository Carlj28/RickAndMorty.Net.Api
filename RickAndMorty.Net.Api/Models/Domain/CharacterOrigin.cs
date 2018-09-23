using System;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class CharacterOrigin
    {
        /// <summary>
        /// Constructor of <see cref="CharacterOrigin"/>.
        /// </summary>
        /// <param name="name">Name to the character's origin location.</param>
        /// <param name="url">Link to the character's origin location.</param>
        public CharacterOrigin(string name = "", Uri url = null)
        {
            Name = name;
            Url = url;
        }

        /// <summary>
        /// Gets name to the character's origin location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets link to the character's origin location.
        /// </summary>
        public Uri Url { get; set; }
    }
}
