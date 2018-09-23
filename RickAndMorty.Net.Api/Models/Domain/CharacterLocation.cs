using System;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class CharacterLocation
    {
        /// <summary>
        /// Constructor of <see cref="CharacterLocation"/>.
        /// </summary>
        /// <param name="name">Name to the character's last known location.</param>
        /// <param name="url">Link to the character's last known location.</param>
        public CharacterLocation(string name = "", Uri url = null)
        {
            Name = name;
            Url = url;
        }

        /// <summary>
        /// Gets name to the character's last known location.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets link to the character's last known location.
        /// </summary>
        public Uri Url { get; }
    }
}
