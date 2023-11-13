namespace ECTPFinalProject.Core.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double Handicap { get; set; }
        public int LeagueId { get; set; }
        public League? League { get; set; }
        public ICollection<Score>? Scores { get; set; }
    }
}