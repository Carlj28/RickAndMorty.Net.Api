using System;
using System.Collections.Generic;

namespace RickAndMorty.Net.Api.Models.Domain
{
    public class Location
    {
        /// <summary>
        /// Constructor of <see cref="Episode"/>.
        /// </summary>
        /// <param name="id">The id of the location.</param>
        /// <param name="name">The name of the location.</param>
        /// <param name="type">The type of the location.</param>
        /// <param name="dimension">The dimension in which the location is located.</param>
        /// <param name="residents">List of character who have been last seen in the location.</param>
        /// <param name="url">Link to the location's own endpoint.</param>
        /// <param name="created">Time at which the location was created in the database.</param>
        public Location(int id = 0, string name = "", string type = "", string dimension = "", IEnumerable<Uri> residents = null,
            Uri url = null, DateTime? created = null)
        {
            Id = id;
            Name = name;
            Type = type;
            Dimension = dimension;
            Residents = residents;
            Url = url;
            Created = created;
        }

        /// <summary>
        /// Gets the id of the location.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of the location.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the dimension in which the location is located.
        /// </summary>
        public string Dimension { get; }

        /// <summary>
        /// Gets list of character who have been last seen in the location.
        /// </summary>
        public IEnumerable<Uri> Residents { get; }

        /// <summary>
        /// Gets link to the location's own endpoint.
        /// </summary>
        public Uri Url { get; }

        /// <summary>
        /// Gets time at which the location was created in the database. 
        /// </summary>
        public DateTime? Created { get; }
    }
}
