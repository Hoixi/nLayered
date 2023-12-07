using Business.Abstracts;
using Entities.Concrates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add(User user)
        {
            await _userService.Add(user);
            return Ok(user);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] User user)
        {
            await _userService.Update(user);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] User user, bool permanentlyDelete)
        {
            await _userService.Delete(user,permanentlyDelete);
            return Ok();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int Id)
        {
            await _userService.Get(Id);
            return Ok();
        }
    }
}
