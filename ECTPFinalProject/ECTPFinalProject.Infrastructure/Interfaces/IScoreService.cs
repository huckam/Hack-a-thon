using ECTPFinalProject.Core.Entities;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface IScoreService
    {
        Score GetScore(int weekNumber, int memberId);
        List<Score> GetAllScores(int memberId);
        void SubmitScore(Score score);
        bool UpdateScore(Score score);
        bool DeleteScore(Score score);
    }
}
