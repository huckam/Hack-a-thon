using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class HoleEntityConfiguration : IEntityTypeConfiguration<Hole>
    {
        public void Configure(EntityTypeBuilder<Hole> builder)
        {
            builder.ToTable(nameof(Hole));
            builder.HasKey(x => x.HoleId).HasName("PK_Hole");
            builder.Property(x => x.HoleId).ValueGeneratedOnAdd().IsRequired();
            builder.HasOne(x => x.GolfCourse).WithMany(x => x.Holes).HasForeignKey(x => x.GolfCourseId);

            builder.HasData(
                new Hole { HoleId = 1, HoleNumber = 1, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 2, HoleNumber = 2, Par = 3, GolfCourseId = 1 },
                new Hole { HoleId = 3, HoleNumber = 3, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 4, HoleNumber = 4, Par = 5, GolfCourseId = 1 },
                new Hole { HoleId = 5, HoleNumber = 5, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 6, HoleNumber = 6, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 7, HoleNumber = 7, Par = 3, GolfCourseId = 1 },
                new Hole { HoleId = 8, HoleNumber = 8, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 9, HoleNumber = 9, Par = 5, GolfCourseId = 1 },

                new Hole { HoleId = 10, HoleNumber = 10, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 11, HoleNumber = 11, Par = 3, GolfCourseId = 1 },
                new Hole { HoleId = 12, HoleNumber = 12, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 13, HoleNumber = 13, Par = 5, GolfCourseId = 1 },
                new Hole { HoleId = 14, HoleNumber = 14, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 15, HoleNumber = 15, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 16, HoleNumber = 16, Par = 3, GolfCourseId = 1 },
                new Hole { HoleId = 17, HoleNumber = 17, Par = 4, GolfCourseId = 1 },
                new Hole { HoleId = 18, HoleNumber = 18, Par = 5, GolfCourseId = 1 },

                new Hole { HoleId = 19, HoleNumber = 1, Par = 3, GolfCourseId = 2 },
                new Hole { HoleId = 20, HoleNumber = 2, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 21, HoleNumber = 3, Par = 5, GolfCourseId = 2 },
                new Hole { HoleId = 22, HoleNumber = 4, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 23, HoleNumber = 5, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 24, HoleNumber = 6, Par = 3, GolfCourseId = 2 },
                new Hole { HoleId = 25, HoleNumber = 7, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 26, HoleNumber = 8, Par = 5, GolfCourseId = 2 },
                new Hole { HoleId = 27, HoleNumber = 9, Par = 4, GolfCourseId = 2 },
                
                new Hole { HoleId = 28, HoleNumber = 10, Par = 3, GolfCourseId = 2 },
                new Hole { HoleId = 29, HoleNumber = 11, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 30, HoleNumber = 12, Par = 5, GolfCourseId = 2 },
                new Hole { HoleId = 31, HoleNumber = 13, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 32, HoleNumber = 14, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 33, HoleNumber = 15, Par = 3, GolfCourseId = 2 },
                new Hole { HoleId = 34, HoleNumber = 16, Par = 4, GolfCourseId = 2 },
                new Hole { HoleId = 35, HoleNumber = 17, Par = 5, GolfCourseId = 2 },
                new Hole { HoleId = 36, HoleNumber = 18, Par = 4, GolfCourseId = 2 }
            );
        }
    }
}
