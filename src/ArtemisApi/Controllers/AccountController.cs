using System;
using System.Linq;
using System.Threading.Tasks;
using ArtemisApi.Data;
using ArtemisApi.Data.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArtemisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ArtemisContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(ArtemisContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] LoginUser model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result != IdentityResult.Success) return BadRequest(result.Errors);

            return Created("User created", new { user.Email });
        }
    }
}