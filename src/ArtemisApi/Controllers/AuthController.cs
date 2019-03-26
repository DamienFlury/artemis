using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ArtemisApi.Data;
using ArtemisApi.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ArtemisApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthController (SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IConfiguration configuration) {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> CreateToken ([FromBody] LoginUser model) {
            
            if (!ModelState.IsValid) return BadRequest ();

            var user = await _userManager.FindByEmailAsync (model.Email);

            if (user is null) return Unauthorized ();

            var loginResult = await _signInManager.CheckPasswordSignInAsync (user, model.Password, false);

            if (!loginResult.Succeeded) return Unauthorized ();

            var claims = new [] {
                new Claim (JwtRegisteredClaimNames.Sub, user.Email),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ()),
                new Claim (JwtRegisteredClaimNames.UniqueName, user.Email)
            };

            var key = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (_configuration["Tokens:Key"]));
            var cred = new SigningCredentials (key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken (
                _configuration["Tokens:Issuer"],
                _configuration["Tokens:Audience"],
                claims,
                expires : DateTime.UtcNow.AddHours(2),
                signingCredentials : cred);

            var result = new {
                Token = new JwtSecurityTokenHandler ().WriteToken (token),
                Expiration = token.ValidTo
            };

            return Created ("", result);
        }
    }
}