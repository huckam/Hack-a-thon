namespace ECTPFinalProject.Core.Entities
{
    public class Hole
    {
        public int HoleId { get; set; }
        public int GolfCourseId { get; set; }
        public GolfCourse GolfCourse { get; set; }
        public int HoleNumber { get; set; }
        public int Par { get; set; }
    }
}