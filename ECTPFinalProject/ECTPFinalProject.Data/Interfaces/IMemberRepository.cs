using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces
{
    public interface IMemberRepository
    {
        void CreateMember(Member member);
        Member GetById(int id);
        Member GetByFirstAndLastName(string firstName, string lastName);
        List<Member> GetAllMembersByLeagueId(int leagueId); 
        bool UpdateMember(Member member);
        bool DeleteMember(int id);
    }
}
