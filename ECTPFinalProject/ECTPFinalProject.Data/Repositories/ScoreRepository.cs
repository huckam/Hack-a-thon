using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly GolfLeagueContext _context;

        public ScoreRepository(GolfLeagueContext context)
        {
            _context = context;
        }

        public void CreateScore(Score score)
        {
            _context.Scores.Add(score);
            _context.SaveChanges();
        }

        public bool DeleteScore(int id)
        {
            var score = GetById(id);
            if (score != null)
            {
                _context.Scores.Remove(score);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Score GetById(int id)
        {
            return _context.Scores.SingleOrDefault(x => x.ScoreId == id) ?? throw new ArgumentNullException();
        }

        public Score GetByWeekNumberAndMemberId(int weekNumber, int memberId)
        {
            return _context.Scores.SingleOrDefault(x => x.WeekNumber == weekNumber && x.MemberId == memberId) ?? throw new ArgumentNullException();
        }

        public bool UpdateScore(Score score)
        {
            var existingScore = GetById(score.ScoreId);
            if (existingScore != null)
            {
                existingScore.WeekNumber = score.WeekNumber;
                existingScore.Hole1Score = score.Hole1Score;
                existingScore.Hole2Score = score.Hole2Score;
                existingScore.Hole3Score = score.Hole3Score;
                existingScore.Hole4Score = score.Hole4Score;
                existingScore.Hole5Score = score.Hole5Score;
                existingScore.Hole6Score = score.Hole6Score;
                existingScore.Hole7Score = score.Hole7Score;
                existingScore.Hole8Score = score.Hole8Score;
                existingScore.Hole9Score = score.Hole9Score;
                existingScore.MemberId = score.MemberId;
                existingScore.Member = score.Member;

                _context.Scores.Update(existingScore);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
