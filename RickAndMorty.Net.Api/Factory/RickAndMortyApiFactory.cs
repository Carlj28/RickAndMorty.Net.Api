using System;
using EnsureThat;
using RickAndMorty.Net.Api.Mapper;
using RickAndMorty.Net.Api.Service;

namespace RickAndMorty.Net.Api.Factory
{
    public abstract class RickAndMortyApiFactory
    {
        /// <summary>
        /// Creates <see cref="IRickAndMortyService"/> interface instance.
        /// </summary>
        /// <returns></returns>
        public static IRickAndMortyService Create()
        {
            var mapper = MapperModule.Resolve();

            var service = new RickAndMortyService(mapper);

            return service;
        }

        /// <summary>
        /// Creates <see cref="IRickAndMortyService"/> interface instance.
        /// </summary>
        /// <param name="url">URL to service.</param>
        /// <returns></returns>
        public static IRickAndMortyService Create(string url)
        {
            Ensure.Bool.IsFalse(String.IsNullOrEmpty(url));

            var mapper = MapperModule.Resolve();

            var service = new RickAndMortyService(mapper, url);

            return service;
        }
    }
}
