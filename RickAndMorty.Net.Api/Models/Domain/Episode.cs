using System;
using System.Collections.Generic;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class Episode
    {
        /// <summary>
        /// Constructor of <see cref="Episode"/>.
        /// </summary>
        /// <param name="id">The id of the episode.</param>
        /// <param name="name">The name of the episode.</param>
        /// <param name="airDate">The air date of the episode.</param>
        /// <param name="episodeCode">The code of the episode. </param>
        /// <param name="characters">List of characters who have been seen in the episode.</param>
        /// <param name="url">Link to the episode's own endpoint.</param>
        /// <param name="created">Time at which the episode was created in the database.</param>
        public Episode(int id = 0, string name = "", DateTime? airDate = null,
            string episodeCode = "", IEnumerable<Uri> characters = null,
            Uri url = null, DateTime? created = null)
        {
            Id = id;
            Name = name;
            AirDate = airDate;
            EpisodeCode = episodeCode;
            Characters = characters;
            Url = url;
            Created = created;
        }

        /// <summary>
        /// Gets the id of the episode.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the episode.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the air date of the episode.
        /// </summary>
        public DateTime? AirDate { get; }

        /// <summary>
        ///	Gets the code of the episode. 
        /// </summary>
        public string EpisodeCode { get; }

        /// <summary>
        /// Gets list of characters who have been seen in the episode.
        /// </summary>
        public IEnumerable<Uri> Characters { get; }

        /// <summary>
        /// Gets link to the episode's own endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the episode was created in the database.
        /// </summary>
        public DateTime? Created { get; }
    }
}
