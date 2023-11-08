using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Interfaces;
using ECTPFinalProject.Infrastructure.Interfaces;

namespace ECTPFinalProject.Infrastructure.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository) 
        { 
            _memberRepository = memberRepository;
        }

        public bool AddMemberToLeague(League league, Member member)
        {
            member.LeagueId = league.LeagueId;
            return _memberRepository.UpdateMember(member);
        }

        public bool RemoveMemberFromLeague(Member member)
        {
            return _memberRepository.DeleteMember(member.MemberId);
        }
    }
}