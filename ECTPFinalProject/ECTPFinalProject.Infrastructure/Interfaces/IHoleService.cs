using ECTPFinalProject.Core.Entities;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface IHoleService
    {
        List<Hole> GetFrontNineHoles(int golfCourseId);
        List<Hole> GetBackNineHoles(int golfCourseId);
    }
}
