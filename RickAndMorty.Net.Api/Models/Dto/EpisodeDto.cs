using System;

namespace RickAndMorty.Net.Api.Models.Dto
{
    internal class EpisodeDto
    {
        /// <summary>
        /// The id of the episode.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the episode.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The air date of the episode.
        /// </summary>
        public string Air_date { get; set; }

        /// <summary>
        ///	The code of the episode. 
        /// </summary>
        public string Episode { get; set; }

        /// <summary>
        /// List of characters who have been seen in the episode.
        /// </summary>
        public string[] Characters { get; set; }

        /// <summary>
        /// Link to the episode's own endpoint.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Time at which the episode was created in the database.
        /// </summary>
        public string Created { get; set; }
    }
}
