using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Contexts;
using ECTPFinalProject.Data.Interfaces;

namespace ECTPFinalProject.Data.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly GolfLeagueContext _context;

        public MemberRepository(GolfLeagueContext context)
        {
            _context = context;
        }

        public void CreateMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public bool DeleteMember(int id)
        {
            var member = GetById(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Member GetByFirstAndLastName(string firstName, string lastName)
        {
            return _context.Members.SingleOrDefault(x => x.FirstName == firstName && x.LastName == lastName) ?? throw new ArgumentNullException();
        }

        public Member GetById(int id)
        {
            return _context.Members.SingleOrDefault(x => x.MemberId == id) ?? throw new ArgumentNullException();
        }

        public List<Member> GetAllMembersByLeagueId(int leagueId)
        {
            return _context.Members.Where(x => x.LeagueId == leagueId).ToList();
        }

        public bool UpdateMember(Member member)
        {
            var existingMember = GetById(member.MemberId);
            if (existingMember != null)
            {
                existingMember.FirstName = member.FirstName;
                existingMember.LastName = member.LastName;
                existingMember.Handicap = member.Handicap;
                existingMember.LeagueId = member.LeagueId;
                existingMember.League = member.League;
                existingMember.Scores = member.Scores;

                _context.Members.Update(existingMember);
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
