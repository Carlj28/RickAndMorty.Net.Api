using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using EnsureThat;
using Newtonsoft.Json;
using RickAndMorty.Net.Api.Helpers;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Models.Dto;

namespace RickAndMorty.Net.Api.Service
{
    public abstract class BaseService
    {
        private HttpClient Client { get; }
        protected IMapper Mapper { get; }

        protected BaseService(IMapper mapper, string baseAddress)
        {
            Mapper = mapper;

            Ensure.Bool.IsTrue(Uri.IsWellFormedUriString(baseAddress, UriKind.RelativeOrAbsolute));

            Client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        protected async Task<T> Get<T>(string path)
        {
            var response = await Client.GetAsync(path);
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync()) : default(T);
        }

        protected async Task<IEnumerable<T>> GetPages<T>(string url)
        {
            var result = new List<T>();
            var nextPage = -1;

            do
            {
                var dto = await Get<PageDto<T>>(nextPage == -1 ? url : $"{url}{(url.Contains("?") ? "" : "?")}page={nextPage}");
                result.AddRange(dto.Results);

                nextPage = dto.Info.Next.GetNextPageNumber();
            }
            while (nextPage != -1);

            return result;
        }
    }
}
