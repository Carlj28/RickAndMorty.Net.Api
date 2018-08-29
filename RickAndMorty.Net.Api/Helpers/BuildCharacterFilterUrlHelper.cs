using System;
using System.Collections.Generic;
using System.Text;
using RickAndMorty.Net.Api.Models.Enums;

namespace RickAndMorty.Net.Api.Helpers
{
    public static class BuildCharacterFilterUrlHelper
    {
        public static string BuildCharacterFilterUrl(this string baseUrl,
            string name = "",
            CharacterStatus? characterStatus = null,
            string species = "",
            string type = "",
            CharacterGender? gender = null) => baseUrl +
                                               (!String.IsNullOrEmpty(name) ? $"name={name}" : "") +
                                               (characterStatus != null ? $"status={characterStatus.ToString()}" : "") +
                                               (!String.IsNullOrEmpty(species) ? $"species={species}" : "") +
                                               (!String.IsNullOrEmpty(type) ? $"type={type}" : "") +
                                               (gender != null ? $"gender={gender.ToString()}" : "");
    }
}
