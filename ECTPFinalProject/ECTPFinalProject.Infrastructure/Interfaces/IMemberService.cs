using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface IMemberService
    {
        bool AddMemberToLeague(League league, Member member);
        bool RemoveMemberFromLeague(Member member);
    }
}
