using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ECTPFinalProject.Data.Helpers
{
    public static class DatabaseHelperExtensions
    {
        public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services, Action<DbContextOptionsBuilder> setup)
        {
            // TODO: Replace context and repositories with your own.

            //services.AddDbContext<SampleContext>(setup);
            //services.AddTransient<ISampleRepository, SampleRepository>();

            return services;
        }

        public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services,
            string connection) =>
            services.AddEntityFrameworkRepositories(options => options.UseServer(connection));

        internal static DbContextOptionsBuilder UseServer(this DbContextOptionsBuilder options, string connection)
            => options.UseSqlServer(connection);
    }
}
