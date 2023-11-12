using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Infrastructure.Interfaces
{
    public interface ILeagueService
    {
        League GetLeague(int leagueId);
        bool UpdateLeague(League league);
    }
}
