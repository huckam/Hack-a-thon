using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Interfaces;
using ECTPFinalProject.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Infrastructure.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;

        public LeagueService(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }

        public League GetLeague(int leagueId)
        {
            return _leagueRepository.GetById(leagueId);
        }

        public bool UpdateLeague(League league)
        {
            return _leagueRepository.UpdateLeague(league);
        }
    }
}
