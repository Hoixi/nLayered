using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concrates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> Get()
        {
            var result = await _courseService.GetCourseCategoryName();
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
           var result= await _courseService.Add(createCourseRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] Course course)
        {
            await _courseService.Update(course);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(Course course,bool permanentlyDelete)
        {
            await _courseService.Delete(course, permanentlyDelete);
            return Ok();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var result = await _courseService.Get(Id);
            return Ok(result);
        }
    }
}
