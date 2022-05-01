using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenPolytechnic.Business.Superheroes.Marvel;
using OpenPolytechnic.Business.Superheroes.Marvel.Interfaces;
using OpenPolytechnic.Repository.Superheroes.DC;
using OpenPolytechnic.Repository.Superheroes.Marvel;
using OpenPolytechnic.Repository.Superheroes.Marvel.Interfaces;

namespace OpenPolytechnic.IoC
{
    /// <summary>
    /// Yer a wizard, 'Arry!
    /// </summary>
    public static class DependencyWizard
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureRepositories(services);
            ConfigureServices(services);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMarvelSuperheroesService, MarvelSuperheroesService>();
        }

        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IMarvelSuperheroesRepository, MarvelSuperheroesRepository>();
            services.AddScoped<IDcSuperheroesRepository, DcSuperheroesRepository>();
        }
    }
}
