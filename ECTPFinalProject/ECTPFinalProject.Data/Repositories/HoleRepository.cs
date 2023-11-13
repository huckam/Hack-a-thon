using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class HoleRepository : IHoleRepository
    {
        private readonly GolfLeagueContext _context;

        public HoleRepository(GolfLeagueContext context)
        {
            _context = context;
        }

        public void CreateHole(Hole hole)
        {
            _context.Holes.Add(hole);
            _context.SaveChanges();
        }

        public bool DeleteHole(int id)
        {
            var hole = GetById(id);
            if (hole != null)
            {
                _context.Remove(hole);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Hole GetById(int id)
        {
            return _context.Holes.SingleOrDefault(x => x.HoleId == id) ?? throw new ArgumentNullException();
        }

        public Hole GetByHoleNumberAndCourseName(int holeNumber, string courseName)
        {
            return _context.Holes.SingleOrDefault(x => x.HoleNumber == holeNumber && x.GolfCourse.Name == courseName) ?? throw new ArgumentNullException();
        }

        public List<Hole> GetFrontNineByGolfCourseId(int golfCourseId)
        {
            var holes = _context.Holes.Where(x => x.GolfCourseId == golfCourseId).ToList();
            return holes.Where(x => x.HoleNumber < 10).ToList();
        }

        public List<Hole> GetBackNineByGolfCourseId(int golfCourseId)
        {
            var holes = _context.Holes.Where(x => x.GolfCourseId == golfCourseId).ToList();
            return holes.Where(x => x.HoleNumber >= 10).ToList();
        }

        public bool UpdateHole(Hole hole)
        {
            var existingHole = GetById(hole.HoleId);
            if (existingHole != null)
            {
                existingHole.GolfCourseId = hole.GolfCourseId;
                existingHole.GolfCourse = hole.GolfCourse;
                existingHole.HoleNumber = hole.HoleNumber;
                existingHole.Par = hole.Par;

                _context.Update(existingHole);
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
