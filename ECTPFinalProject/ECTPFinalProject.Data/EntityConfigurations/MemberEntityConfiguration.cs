using Microsoft.EntityFrameworkCore;
using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class MemberEntityConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable(nameof(Member));
            builder.HasKey(x => x.MemberId).HasName("PK_Member");
            builder.Property(x => x.MemberId).ValueGeneratedOnAdd().IsRequired();
            builder.HasOne(x => x.League).WithMany(x => x.Members).HasForeignKey(x => x.LeagueId);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);

            builder.HasData(
                new Member { MemberId = 1, FirstName = "Anthony", LastName = "Huck", LeagueId = 1, Handicap = 20 },
                new Member { MemberId = 2, FirstName = "Patrick", LastName = "Dewey", LeagueId = 1, Handicap = 3000 }
            );
        }
    }
}
