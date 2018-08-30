namespace RickAndMorty.Net.Api.Models.Dto
{
    internal class LocationDto
    {
        /// <summary>
        /// The id of the location.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the location.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The dimension in which the location is located.
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// List of character who have been last seen in the location.
        /// </summary>
        public string[] Residents { get; set; }

        /// <summary>
        /// Link to the location's own endpoint.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Time at which the location was created in the database. 
        /// </summary>
        public string Created { get; set; }
    }
}
