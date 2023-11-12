using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfLeagueController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IScoreService _scoreService;
        private readonly ILeagueService _leagueService;

        public GolfLeagueController(IMemberService memberService, IScoreService scoreService, ILeagueService leagueService)
        {
            _memberService = memberService;
            _scoreService = scoreService;
            _leagueService = leagueService;
        }

        [HttpPost("[action]")]
        public IActionResult AddMemberToLeague(Member member)
        {
            try
            {
                _memberService.AddMemberToLeague(member);
                var league = _leagueService.GetLeague(member.LeagueId);
                _leagueService.UpdateLeague(league);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("[action]")]
        public IActionResult RemoveMemberFromLeague(int memberId)
        {
            try
            {
                var member = _memberService.GetById(memberId);
                _memberService.RemoveMemberFromLeague(memberId);
                var league = _leagueService.GetLeague(member.MemberId);
                _leagueService.UpdateLeague(league);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
