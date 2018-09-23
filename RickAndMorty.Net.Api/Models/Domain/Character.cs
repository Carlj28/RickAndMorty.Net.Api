using System;
using System.Collections.Generic;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class Character
    {
        /// <summary>
        /// Constructor of <see cref="Character"/>.
        /// </summary>
        /// <param name="id">The id of the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="status">The status of the character ('Alive', 'Dead' or 'unknown').</param>
        /// <param name="species">The species of the character.</param>
        /// <param name="type">The type or subspecies of the character.</param>
        /// <param name="gender">The gender of the character ('Female', 'Male', 'Genderless' or 'unknown').</param>
        /// <param name="location">Name and link to the character's last known location endpoint.</param>
        /// <param name="origin">Name and link to the character's origin location.</param>
        /// <param name="image">Link to the character's image. All images are 300x300px and most are medium shots or portraits since they are intended to be used as avatars.</param>
        /// <param name="episode">List of episodes in which this character appeared.</param>
        /// <param name="url">Link to the character's own URL endpoint.</param>
        /// <param name="created">Time at which the character was created in the database.</param>
        public Character(int id = 0, string name = "", CharacterStatus status = 0,
            string species = "", string type = "", CharacterGender gender = 0,
            CharacterLocation location = null, CharacterOrigin origin = null, Uri image = null,
            IEnumerable<Uri> episode = null, Uri url = null, DateTime? created = null)
        {
            Id = id;
            Name = name;
            Status = status;
            Species = species;
            Type = type;
            Gender = gender;
            Location = location;
            Origin = origin;
            Image = image;
            Episode = episode;
            Url = url;
            Created = created;
        }

        /// <summary>
        /// Gets the id of the character.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the status of the character ('Alive', 'Dead' or 'unknown').
        /// </summary>
        public CharacterStatus Status { get; }

        /// <summary>
        /// Gets the species of the character.
        /// </summary>
        public string Species { get; }

        /// <summary>
        /// Gets the type or subspecies of the character.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the gender of the character ('Female', 'Male', 'Genderless' or 'unknown').
        /// </summary>
        public CharacterGender Gender { get; }

        /// <summary>
        /// Gets name and link to the character's last known location endpoint.
        /// </summary>
        public CharacterLocation Location { get; }

        /// <summary>
        /// Gets name and link to the character's origin location.
        /// </summary>
        public CharacterOrigin Origin { get; }

        /// <summary>
        /// Gets link to the character's image. All images are 300x300px and most are medium shots or portraits since they are intended to be used as avatars.
        /// </summary>
        public Uri Image { get; }

        /// <summary>
        /// Gets list of episodes in which this character appeared.
        /// </summary>
        public IEnumerable<Uri> Episode { get; }

        /// <summary>
        /// Gets link to the character's own URL endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the character was created in the database.
        /// </summary>
        public DateTime? Created { get; }
    }
}
