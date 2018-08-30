using System.Collections.Generic;
using System.Threading.Tasks;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Service
{
    public interface IRickAndMortyService
    {
        /// <summary>
        /// Get a single character.
        /// </summary>
        /// <param name="id">Id of character.</param>
        /// <returns>Character.</returns>
        Task<Character> GetCharacter(int id);

        /// <summary>
        /// Get all characters.
        /// </summary>
        /// <returns>Characters enumerable.</returns>
        Task<IEnumerable<Character>> GetAllCharacters();

        /// <summary>
        /// Get multiple characters.
        /// </summary>
        /// <param name="ids">Characters id's.</param>
        /// <returns>Characters enumerable.</returns>
        Task<IEnumerable<Character>> GetMultipleCharacters(int[] ids);

        /// <summary>
        /// Filter characters.
        /// </summary>
        /// <param name="name">Filter by the given name.</param>
        /// <param name="characterStatus">Filter by the given status (alive, dead or unknown).</param>
        /// <param name="species">Filter by the given species.</param>
        /// <param name="type">Filter by the given type.</param>
        /// <param name="gender">Filter by the given gender (female, male, genderless or unknown).</param>
        /// <returns>Characters enumerable.</returns>
        Task<IEnumerable<Character>> FilterCharacters(string name = "",
            CharacterStatus? characterStatus = null,
            string species = "",
            string type = "",
            CharacterGender? gender = null);

        /// <summary>
        /// Get all locations.
        /// </summary>
        /// <returns>Locations enumerable.</returns>
        Task<IEnumerable<Location>> GetAllLocations();

        /// <summary>
        /// Get multiple locations.
        /// </summary>
        /// <param name="ids">Locations id's.</param>
        /// <returns>Locations enumerable.</returns>
        Task<IEnumerable<Location>> GetMultipleLocations(int[] ids);

        /// <summary>
        /// Get location.
        /// </summary>
        /// <param name="id">Location id.</param>
        /// <returns>Location.</returns>
        Task<Location> GetLocation(int id);

        /// <summary>
        /// Filter locations.
        /// </summary>
        /// <param name="name">Filter by the given name.</param>
        /// <param name="type">Filter by the given type.</param>
        /// <param name="dimension">Filter by the given dimension.</param>
        /// <returns>Locations enumerable.</returns>
        Task<IEnumerable<Location>> FilterLocations(string name = "",
            string type = "",
            string dimension = "");

        /// <summary>
        /// Get all episodes.
        /// </summary>
        /// <returns>Episodes enumerable.</returns>
        Task<IEnumerable<Episode>> GetAllEpisodes();

        /// <summary>
        /// Get episode.
        /// </summary>
        /// <param name="id">Episode id.</param>
        /// <returns>Episode.</returns>
        Task<Episode> GetEpisode(int id);

        /// <summary>
        /// Get multiple episodes.
        /// </summary>
        /// <param name="ids">Episodes id's.</param>
        /// <returns>Episodes enumerable.</returns>
        Task<IEnumerable<Episode>> GetMultipleEpisodes(int[] ids);

        /// <summary>
        /// Filter episodes.
        /// </summary>
        /// <param name="name">Filter by the given name.</param>
        /// <param name="episode">Filter by the given episode code.</param>
        /// <returns>Episodes enumerable.</returns>
        Task<IEnumerable<Episode>> FilterEpisodes(string name = "",
            string episode = "");
    }
}
