using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,loginModel.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AAAAAAAAAAAAAAAAAAA"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenObject = new JwtSecurityToken(
                issuer:"SoftwareOrg",
                audience:"WebApp",
                claims:claims,
                expires:DateTime.Now.AddMinutes(30),
                signingCredentials:creds
                );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenObject);
            return Ok(token);
        }
    }
}
