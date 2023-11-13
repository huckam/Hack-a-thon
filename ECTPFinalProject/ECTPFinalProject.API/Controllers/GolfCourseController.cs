using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfCourseController : Controller
    {
        private readonly IHoleService _holeService;

        public GolfCourseController(IHoleService holeService)
        {
            _holeService = holeService;
        }

        [HttpGet("[action]/golfCourseId")]
        public IActionResult GetFrontNineInfo(int golfCourseId)
        {
            try
            {
                var frontNineHoles = _holeService.GetFrontNineHoles(golfCourseId);
                return Ok(frontNineHoles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("[action]/golfCourseId")]
        public IActionResult GetBackNineInfo(int golfCourseId)
        {
            try
            {
                var backNineHoles = _holeService.GetBackNineHoles(golfCourseId);
                return Ok(backNineHoles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
