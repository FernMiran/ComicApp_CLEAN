using ComicApp.Domain.Repositories.Commands;
using ComicApp.Infrastructure.Repositories.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.Extensions
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IComicCommandRepository, ComicCommandRepository>();
            services.AddScoped<ICharacterCommandRepository, CharacterCommandRepository>();
            services.AddScoped<IComicCharacterCommandRepository, ComicCharacterCommandRepository>();

            return services;
        }
    }
}
