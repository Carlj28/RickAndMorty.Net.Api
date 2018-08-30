using System;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Helpers
{
    public static class BuildFilterUrlHelpers
    {
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
    }
}
