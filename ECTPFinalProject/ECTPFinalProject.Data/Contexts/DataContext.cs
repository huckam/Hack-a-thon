using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ECTPFinalProject.Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> context) : base(context)
    { }

    public DbSet<Event> Events { get; set; }
    public DbSet<EventType> EventTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO: Replace with your own entity configurations.
        modelBuilder.ApplyConfiguration(new EventEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EventTypeEntityTypeConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}