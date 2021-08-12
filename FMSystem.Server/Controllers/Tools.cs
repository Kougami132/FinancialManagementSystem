using FMSystem.Shared;
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
    public static class Tools
    {
        public static string GetToken(FMContext _context, IConfiguration _configuration, string name)
        {
            //此处加入账号密码验证代码
            User user = _context.Users.FirstOrDefault(i => i.UserName.ToLower() == name.ToLower());
            name = user == null ? name : user.UserName;
            string role = user == null ? "" : user.Permission == Permissions.ADMIN ? "Admin" : "Normal";
            var claims = new Claim[]
            {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(role, role),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtAudience"],
                claims: claims,
                expires: DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"])),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static bool IsUserExist(FMContext _context, string userName)
        {
            if (_context.Users.Any(i => i.UserName.ToLower() == userName.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
