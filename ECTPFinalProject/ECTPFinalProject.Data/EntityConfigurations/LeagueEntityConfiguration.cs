using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class LeagueEntityConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.ToTable(nameof(League));
            builder.HasKey(x => x.LeagueId).HasName("Pk_League");
            builder.Property(x => x.LeagueId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);

            builder.HasData(
                new League { LeagueId = 1, Name = "CGI Golf", GolfCourseId = 1 }
            );

        }
    }
}
