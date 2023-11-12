using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly ILeagueService _leagueService;

        public MemberController(IMemberService memberService, ILeagueService leagueService)
        {
            _memberService = memberService;
            _leagueService = leagueService;
        }

        [HttpGet("[action]/leagueId")]
        public IActionResult GetAllMembersInLeague(int leagueId)
        {
            try
            {
                var members = _memberService.GetAllMembersByLeagueId(leagueId);
                return Ok(members);
            } 
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
