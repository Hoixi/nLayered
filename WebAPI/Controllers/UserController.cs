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

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int Id)
        {
            await _userService.Get(Id);
            return Ok();
        }
    }
}
