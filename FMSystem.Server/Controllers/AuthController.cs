using FMSystem.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FMSystem.Server.Controllers 
{
    [ApiController]
    [Route("Api/[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly FMContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(FMContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        //注册
        [HttpPost]
        public async Task<Response> Register(User registerUser)
        {
            try
            {
                registerUser.Permission = Permissions.NORMAL;
                await _context.Users.AddAsync(registerUser);
                await _context.SaveChangesAsync();
                return new Response(1);
            }
            catch
            {
                return new Response(0);
            }
        }

        //登录
        [HttpPost]
        public ActionResult<UserDto> Login(LoginDto dto)
        {
            if (!_context.Users.Any(i => i.UserName.ToLower() == dto.UserName.ToLower() && i.UserPwd == dto.Password))
            {
                return new UserDto() { Name = "", Token = "" };
            }
            //模拟获得Token
            string jwtToken = Tools.GetToken(_context, _configuration, dto.UserName);

            return new UserDto() { Name = dto.UserName, Token = jwtToken };
        }

        //获得用户，当页面客户端页面刷新时调用以获得用户信息
        [HttpGet]
        public ActionResult<UserDto> GetUser()
        {
            if (User.Identity.IsAuthenticated && _context.Users.Any(i => i.UserName.ToLower() == User.Identity.Name.ToLower()))//如果Token有效且用户存在
            {
                string name = User.Claims.First(x => x.Type == ClaimTypes.Name).Value;          //从Token中拿出用户ID
                string jwtToken = Tools.GetToken(_context, _configuration, name);               //模拟获得Token
                return new UserDto() { Name = name, Token = jwtToken };
            }
            else
            {
                return new UserDto() { Name = null, Token = null };
            }
        }

        

    }

}
