using ECTPFinalProject.Infrastructure.Interfaces;
using ECTPFinalProject.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;


namespace ECTPFinalProject.Infrastructure.Helpers
{
    public static class InfrastructureHelperExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // TODO: Replace with your services.

            services.AddTransient<ILeagueService, LeagueService>();
            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<IScoreService, ScoreService>();

            return services;
        }
    }
}
