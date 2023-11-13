using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class ScoreEntityConfiguration : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.ToTable(nameof(Score));
            builder.HasKey(x => x.ScoreId).HasName("PK_Score");
            builder.Property(x => x.ScoreId).ValueGeneratedOnAdd().IsRequired();
            builder.HasOne(x => x.Member).WithMany(x => x.Scores).HasForeignKey(x => x.MemberId);

            builder.HasData(
                new Score
                {
                    ScoreId = 1,
                    WeekNumber = 1,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 1
                },
                new Score
                {
                    ScoreId = 2,
                    WeekNumber = 2,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 1
                },
                new Score
                {
                    ScoreId = 3,
                    WeekNumber = 3,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 1
                },
                new Score
                {
                    ScoreId = 4,
                    WeekNumber = 1,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 2
                },
                new Score
                {
                    ScoreId = 5,
                    WeekNumber = 2,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 2
                },
                new Score
                {
                    ScoreId = 6,
                    WeekNumber = 3,
                    Hole1Score = 4,
                    Hole2Score = 4,
                    Hole3Score = 4,
                    Hole4Score = 4,
                    Hole5Score = 4,
                    Hole6Score = 4,
                    Hole7Score = 4,
                    Hole8Score = 4,
                    Hole9Score = 4,
                    MemberId = 2
                }
            );
        }
    }
}
