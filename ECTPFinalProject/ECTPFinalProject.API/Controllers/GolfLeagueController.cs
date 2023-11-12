using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfLeagueController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IScoreService _scoreService;
        //test push
        public GolfLeagueController(IMemberService memberService, IScoreService scoreService)
        {
            _memberService = memberService;
            _scoreService = scoreService;
        }

        [HttpPost]
        public IActionResult AddMemberToLeague(League league, int memberId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult RemoveMemberFromLeague(League league, int memberId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult AddScoreForMember(int memberId, Score score)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult UpdateScoreForMember(int memberId, Score score)
        { 
            throw new NotImplementedException(); 
        }

        [HttpPost]
        public IActionResult DeleteScoreForMember(int memberId, Score score)
        {
            throw new NotImplementedException();
        }
    }
}
