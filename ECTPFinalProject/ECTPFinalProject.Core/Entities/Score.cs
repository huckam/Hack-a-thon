namespace ECTPFinalProject.Core.Entities
{
    public class Score
    {
        public int ScoreId { get; set; }
        public int WeekNumber { get; set; }
        public int Hole1Score { get; set; }
        public int Hole2Score { get; set; }
        public int Hole3Score { get; set; }
        public int Hole4Score { get; set; }
        public int Hole5Score { get; set; }
        public int Hole6Score { get; set; }
        public int Hole7Score { get; set; }
        public int Hole8Score { get; set; }
        public int Hole9Score { get; set; }
        public int MemberId { get; set; }
        public Member? Member { get; set; }
    }
}
