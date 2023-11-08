using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class GolfCourseEntityConfiguration : IEntityTypeConfiguration<GolfCourse>
    {
        public void Configure(EntityTypeBuilder<GolfCourse> builder)
        {
            builder.ToTable(nameof(GolfCourse));
            builder.HasKey(x => x.GolfCourseId).HasName("PK_GolfCourse");
            builder.Property(x => x.GolfCourseId).ValueGeneratedOnAdd().IsRequired();

            builder.HasData(
                new GolfCourse { GolfCourseId = 1, Name = "Pebble Beach" },
                new GolfCourse { GolfCourseId = 2, Name = "Augusta National" }
            );
        }
    }
}
