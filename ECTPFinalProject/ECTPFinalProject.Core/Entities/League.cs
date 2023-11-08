namespace ECTPFinalProject.Core.Entities
{
    public class League
    {
        public int LeagueId { get; set; }
        public string? Name { get; set; }
        public int GolfCourseId { get; set; }
        public GolfCourse? GolfCourse { get; set; }
        public List<Member>? Members { get; set; }
    }
}
