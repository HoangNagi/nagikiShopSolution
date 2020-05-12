using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nagikiShopSolution.Application.System.Users;
using NagikiShopSolution.ViewModels.System.Users;

namespace nagikiShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authencate")]
        [AllowAnonymous]
          public async Task<IActionResult> Authemcate([FromForm]LoginRequest request)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);
            var resultToken =await _userService.Authencate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("Donkey it's wrong");
            }
            return Ok(new { token = resultToken});
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userService.Register(request);
            if (!result)
            {
                return BadRequest("Donkey it's wrong");
            }
            return Ok();
        }
    }
}