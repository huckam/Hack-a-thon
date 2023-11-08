using ECTPFinalProject.Core.Entities;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface IScoreService
    {
        Score GetScore(int weekNumber, int memberId);
        bool SubmitScore(Score score, int memberId);
        bool UpdateScore(Score score, int memberId);
        bool DeleteScore(Score score);
    }
}
