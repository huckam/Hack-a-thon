
//namespace ECTPFinalProject.Data;

//public static class DatabaseHelperExtensions
//{
//    public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services,
//        Action<DbContextOptionsBuilder> setup) =>
//        services.AddDbContext<ExampleContext>(setup)
//            .AddScoped<IExampleRepository, ExampleRepository>()


//    public static IServiceCollection AddEntityFrameworkRepositories(this IServiceCollection services,
//        string connection) =>
//        services.AddEntityFrameworkRepositories(options => options.UseServer(connection));

//    internal static DbContextOptionsBuilder UseServer(this DbContextOptionsBuilder options, string connection)
//        => options.UseSqlServer(connection);
//}