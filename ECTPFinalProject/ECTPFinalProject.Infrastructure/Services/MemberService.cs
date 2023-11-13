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

        public void AddMemberToLeague(Member member)
        {
            _memberRepository.CreateMember(member);
        }

        public Member GetById(int memberId)
        {
            return _memberRepository.GetById(memberId);
        }

        public List<Member> GetAllMembersByLeagueId(int leagueId) 
        {
            return _memberRepository.GetAllMembersByLeagueId(leagueId);
        }

        public bool RemoveMemberFromLeague(int memberId)
        {
            return _memberRepository.DeleteMember(memberId);
        }

        public bool UpdateMemeber(Member member)
        {
            return _memberRepository.UpdateMember(member);
        }
    }
}