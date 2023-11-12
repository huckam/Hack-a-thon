using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Interfaces;
using ECTPFinalProject.Infrastructure.Interfaces;

namespace ECTPFinalProject.Infrastructure.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public bool DeleteScore(Score score)
        {
            return _scoreRepository.DeleteScore(score.ScoreId);
        }

        public Score GetScore(int weekNumber, int memberId)
        {
            return _scoreRepository.GetByWeekNumberAndMemberId(weekNumber, memberId);
        }

        public List<Score> GetAllScores(int memberId)
        {
            return _scoreRepository.GetAllScoresByMemberId(memberId);
        }

        public void SubmitScore(Score score)
        {
            _scoreRepository.CreateScore(score);
        }

        public bool UpdateScore(Score score)
        {
            throw new NotImplementedException();
        }
    }
}
