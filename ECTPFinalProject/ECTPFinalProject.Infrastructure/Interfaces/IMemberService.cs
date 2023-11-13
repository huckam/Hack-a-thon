using ECTPFinalProject.Core.Entities;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface IMemberService
    {
        void AddMemberToLeague(Member member);
        bool RemoveMemberFromLeague(int memberId);
        bool UpdateMemeber(Member member);
        Member GetById(int memberId);
        List<Member> GetAllMembersByLeagueId(int leagueId);
    }
}
