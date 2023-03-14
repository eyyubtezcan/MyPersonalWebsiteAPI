using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.TokenModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Service.Abstract;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyPersonalWebsite.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class AuthController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;

       // public static User user = new User();
        public AuthController(IConfiguration config,
            IHttpContextAccessor httpContextAccessor ,
            IUserService userService)
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;


        }
        [Authorize(Roles ="Admin")]
        [HttpPost("getUsers")]
        public ActionResult<List<User>> GetUsers(UserFilterModel filterModel)
        {
            List<User> res = new List<User>();

            res = _userService.GetUsers(filterModel).Result;


            return res;
        }

        [HttpPost("register")]
        public ActionResult<User> Register (User request)
        {
          
          

            return Ok();
        }


        [HttpPost("login")]
        public  ActionResult<TokenResponse> Login([FromBody] LoginRequestModel login)
        {
            ActionResult response = Unauthorized();

            if (login is null)
            {
                return BadRequest("Invalid user request!!!");
            }
              var user = _userService.Login(login);



            if (user.isOk)
            {

                TokenResponse token = CreateToken(user.Result);

                Console.WriteLine("The JWT OK:");
                response = Ok(token);
            }
            else
            {
                response = BadRequest(user.Result.ErrorMessage);
            }

            return response;
        }
        private TokenResponse CreateToken(LoginResponseModel user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.UserName),
                 new Claim(ClaimTypes.Role,"Admin")
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                   _config.GetSection("Jwt:Key").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            TokenResponse tokenResponse = new TokenResponse(
            Token: jwt,
            ExpiryDate:DateTime.Now.AddDays(1));

            return tokenResponse;


        }
        [Authorize]
        [HttpGet("logout")]
        public ActionResult Logout()
        {
            string rawUserId= HttpContext.User.FindFirstValue("id");

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            Console.WriteLine("Log out successfull");
            return Ok();
        }

    }
}
