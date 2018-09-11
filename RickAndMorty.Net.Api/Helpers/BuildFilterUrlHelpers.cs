using System;
using System.Runtime.CompilerServices;
using RickAndMorty.Net.Api.Models.Enums;

[assembly: InternalsVisibleTo("RickAndMorty.Net.Api.Tests")]
namespace RickAndMorty.Net.Api.Helpers
{
    internal static class BuildFilterUrlHelpers
    {
        //TODO: change to generic param method Dictionary<string, string>? value and nameof?

        public static string BuildCharacterFilterUrl(this string baseUrl,
            string name = "",
            CharacterStatus? status = null,
            string species = "",
            string type = "",
            CharacterGender? gender = null) => baseUrl + "?" +
                                               (!String.IsNullOrEmpty(name) ? $"{nameof(name)}={name}&" : "") +
                                               (status != null ? $"{nameof(status)}={status.ToString()}&" : "") +
                                               (!String.IsNullOrEmpty(species) ? $"{nameof(species)}={species}&" : "") +
                                               (!String.IsNullOrEmpty(type) ? $"{nameof(type)}={type}&" : "") +
                                               (gender != null ? $"{nameof(gender)}={gender.ToString()}" : "");

        public static string BuildLocationFilterUrl(this string baseUrl,
            string name = "",
            string type = "",
            string dimension = "") => baseUrl + "?" +
                                      (!String.IsNullOrEmpty(name) ? $"{nameof(name)}={name}&" : "") +
                                      (!String.IsNullOrEmpty(type) ? $"{nameof(type)}={type}&" : "") +
                                      (!String.IsNullOrEmpty(dimension) ? $"{nameof(dimension)}={dimension}" : "");

        public static string BuildEpisodeFilterUrl(this string baseUrl,
            string name = "",
            string episode = "") => baseUrl + "?" +
                                      (!String.IsNullOrEmpty(name) ? $"{nameof(name)}={name}&" : "") +
                                      (!String.IsNullOrEmpty(episode) ? $"{nameof(episode)}={episode}&" : "");
    }
}
