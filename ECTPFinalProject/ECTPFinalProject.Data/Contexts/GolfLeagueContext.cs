using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ECTPFinalProject.Data.Contexts
{
    public class GolfLeagueContext : DbContext
    {
        public GolfLeagueContext() { }
        public GolfLeagueContext(DbContextOptions<GolfLeagueContext> context) : base(context) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GolfLeagueContext");
        }

        public DbSet<GolfCourse> GolfCourses { get; set; }
        public DbSet<Hole> Holes { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GolfCourseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new HoleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LeagueEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MemberEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ScoreEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
