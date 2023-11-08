using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

using ECTPFinalProject.Data.Repositories;


namespace ECTPFinalProject.Data.Helpers
{
    public static class DatabaseHelperExtensions
    {
        public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services,
            Action<DbContextOptionsBuilder> setup) =>
            services.AddDbContext<DataContext>(setup)
                .AddScoped<IEventRepository, EventRepository>()
                .AddScoped<IEventTypeRepository, EventTypeRepository>();

        public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services,
            string connection) =>
            services.AddEntityFrameworkRepositories(options => options.UseServer(connection));

        internal static DbContextOptionsBuilder UseServer(this DbContextOptionsBuilder options, string connection)
            => options.UseSqlServer(connection);
    }
}
