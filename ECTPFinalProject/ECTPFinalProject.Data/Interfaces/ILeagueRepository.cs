using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces
{
    public interface ILeagueRepository
    {
        void CreateLeague(League league);
        League GetById(int id);
        League GetByName(string name);
        bool UpdateLeague(League league);
        bool DeleteLeague(int id);
    }
}
