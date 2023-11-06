using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> context) : base(context)
        {
        }

        // TODO: Replace with your own DbSets.

        public DbSet<Event> Event { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Replace with your own entity configurations.
            //modelBuilder.ApplyConfiguration(new SampleEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}