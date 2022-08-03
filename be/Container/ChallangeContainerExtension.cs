

namespace challenge.Container
{
    using challenge.AppProcess;
    using challenge.Database;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Der Einfachheit halber wird hier der Service-Container auch für die App-Models genutzt
    /// </summary>
    public static class ChallangeContainerExtension
    {
        public static IServiceCollection AddThings(this IServiceCollection services)
        {
            services.AddTransient(typeof(INoteDbService), typeof(NoteDbService));
            services.AddTransient(typeof(INoteAppService), typeof(NoteAppService));

            return services;
        }
    }
}
