using Autofac;
using RickAndMorty.Net.Api.Mapper;
using RickAndMorty.Net.Api.Models.Domain;
using RickAndMorty.Net.Api.Service;

namespace RickAndMorty.Net.Api.DI
{
    public class RickAndMortyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RickAndMortyService>()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.Register(ctx => MapperModule.Resolve())
                .As<IRickAndMortyMapper>()
                .SingleInstance();
        }
    }
}
