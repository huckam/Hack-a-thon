using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly GolfLeagueContext _context;

        public LeagueRepository(GolfLeagueContext context)
        {
            _context = context;
        }

        public void CreateLeague(League league)
        {
            _context.Leagues.Add(league);
            _context.SaveChanges();
        }

        public bool DeleteLeague(int id)
        {
            var league = GetById(id);
            if (league != null)
            {
                _context.Leagues.Remove(league);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public League GetById(int id)
        {
            return _context.Leagues.SingleOrDefault(x => x.LeagueId == id);
        }

        public League GetByName(string name)
        {
            return _context.Leagues.SingleOrDefault(x => x.Name == name);
        }

        public bool UpdateLeague(League league)
        {
            var existingLeague = GetById(league.LeagueId);
            if (existingLeague != null)
            {
                existingLeague.Name = league.Name;
                existingLeague.GolfCourseId = league.GolfCourseId;
                existingLeague.GolfCourse = league.GolfCourse;
                existingLeague.Members = league.Members;

                _context.Leagues.Update(existingLeague);
                _context.SaveChanges(true);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
