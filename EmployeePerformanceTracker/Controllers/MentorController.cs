using Microsoft.AspNetCore.Mvc;
using EmployeePerformanceTracker.Models;
using EmployeePerformanceTracker.Services;

namespace EmployeePerformanceTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : Controller
    {
        public readonly MentorService _mentorService;
        public MentorController(MentorService mentorService)
        {
            _mentorService = mentorService;
        }

        #region getall
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mentorService.GetAll();
            return Ok(result);
        }
        #endregion

        #region getbyid
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _mentorService.GetMentorDetailsById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        #endregion

        #region
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Mentor entity)
        {
            await _mentorService.UpdateMentorDetails(entity);
            await _mentorService.Save();
            return Ok(entity);
        }
        #endregion
    }
}
