using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class GolfCourseRepository : IGolfCourseRepository
    {
        private readonly GolfLeagueContext _context;

        public GolfCourseRepository(GolfLeagueContext context)
        {
            _context = context;
        }

        public void CreateGolfCourse(GolfCourse golfCourse)
        {
            _context.GolfCourses.Add(golfCourse);
            _context.SaveChanges();
        }

        public bool DeleteGolfCourse(int id)
        {
            var golfCourse = GetById(id);
            if (golfCourse != null)
            {
                _context.GolfCourses.Remove(golfCourse);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public GolfCourse GetById(int id)
        {
            return _context.GolfCourses.SingleOrDefault(x => x.GolfCourseId == id);
        }

        public GolfCourse GetByName(string name)
        {
            return _context.GolfCourses.SingleOrDefault(x => x.Name == name);
        }

        public bool UpdateGolfCourse(GolfCourse golfCourse)
        {
            var existingGolfCourse = GetByName(golfCourse.Name);
            if (existingGolfCourse != null)
            {
                existingGolfCourse.Name = golfCourse.Name;
                existingGolfCourse.Holes = golfCourse.Holes;

                _context.GolfCourses.Update(existingGolfCourse);
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
