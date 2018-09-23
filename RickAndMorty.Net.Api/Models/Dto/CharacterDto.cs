using System;

namespace RickAndMorty.Net.Api.Models.Dto
{
    internal class CharacterDto
    {

        /// <summary>
        /// The id of the character.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the character ('Alive', 'Dead' or 'unknown').
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The species of the character.
        /// </summary>
        public string Species { get; set; }

        /// <summary>
        /// The type or subspecies of the character.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The gender of the character ('Female', 'Male', 'Genderless' or 'unknown').
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Name and link to the character's last known location endpoint.
        /// </summary>
        public CharacterLocationDto Location { get; set; }

        /// <summary>
        /// Name and link to the character's origin location.
        /// </summary>
        public CharacterOriginDto Origin { get; set; }

        /// <summary>
        /// Link to the character's image. All images are 300x300px and most are medium shots or portraits since they are intended to be used as avatars.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// List of episodes in which this character appeared.
        /// </summary>
        public string[] Episode { get; set; }


        /// <summary>
        /// Link to the character's own URL endpoint.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Time at which the character was created in the database.
        /// </summary>
        public string Created { get; set; }
    }
}
