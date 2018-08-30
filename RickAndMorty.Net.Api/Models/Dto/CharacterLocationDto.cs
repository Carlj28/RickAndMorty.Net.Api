namespace RickAndMorty.Net.Api.Models.Dto
{
    internal class CharacterLocationDto
    {
        /// <summary>
        /// Name to the character's last known location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to the character's last known location.
        /// </summary>
        public string Url { get; set; }
    }
}
