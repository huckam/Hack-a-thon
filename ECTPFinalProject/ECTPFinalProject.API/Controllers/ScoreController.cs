using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    public class ScoreController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IScoreService _scoreService;

        public ScoreController(IMemberService memberService, IScoreService scoreService)
        {
            _memberService = memberService;
            _scoreService = scoreService;
        }

        [HttpGet("[action]/memberId")]
        public IActionResult GetListOfScoresByMemberId(int memberId)
        {
            try
            {
                var scores = _scoreService.GetAllScores(memberId);
                return Ok(scores);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("[action]/memberId/weekId")]
        public IActionResult GetScoreByMemberIdAndWeekId(int memberId, int weekId)
        {
            try
            {
                var score = _scoreService.GetScore(weekId, memberId);
                return Ok(score);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("[action]")]
        public IActionResult AddScoreForMember(Score score)
        {
            try
            {
                _scoreService.SubmitScore(score);
                var member = _memberService.GetById(score.MemberId);
                _memberService.UpdateMemeber(member);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("[action]")]
        public IActionResult UpdateScoreForMember(Score score)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("[action]/memberId")]
        public IActionResult DeleteScoreForMember(Score score)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
