using FMSystem.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMSystem.Server.Controllers
{
    [ApiController]
    [Route("Api/[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly FMContext _context;

        public UserController(FMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<User> GetSelf()
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                return _context.Users.FirstOrDefault(i => i.UserName == User.Identity.Name);
            }
            else
            {
                return null;
            }
        }
        
        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            if (IsUserAdmin(User.Identity.Name)) //如果Token权限为Admin
            {
                return _context.Users.ToArray();
            }
            else
            {
                return new User[0];
            }
        }

        [HttpGet]
        public ActionResult<Response> IsUserExist(string userName)
        {
            try
            {
                if (_context.Users.Any(i => i.UserName.ToLower() == userName.ToLower()))
                {
                    return new Response(1, "Yes");
                }
                else
                {
                    return new Response(1, "No");
                }
            }
            catch
            {
                return new Response(0);
            }
        }

        [HttpGet]
        public bool IsUserAdmin(string userName)
        {
            if (User.Identity.IsAuthenticated && IsUserExist(User.Identity.Name).Value.Msg == "Yes")
            {
                if (_context.Users.Any(i => i.UserName.ToLower() == userName.ToLower() && i.Permission == Permissions.ADMIN))
                {
                    return true;
                }
            }
            return false;
        }

        [HttpPost]
        public async Task<Response> AddUser(User newUser)
        {
            if (IsUserAdmin(User.Identity.Name)) //如果Token权限为Admin
            {
                try
                {
                    await _context.Users.AddAsync(newUser);
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                catch
                {
                    return new Response(0);
                }
            }
            else
            {
                return new Response(0);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> EditUser(User editUser)
        {
            if (IsUserAdmin(User.Identity.Name) || _context.Users.Find(editUser.Id).UserName == User.Identity.Name) //如果Token权限为Admin或修改自己信息
            {
                try
                {
                    _context.Users.Update(editUser);
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                catch
                {
                    return new Response(0);
                }
            }
            else
            {
                return new Response(0);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> DeleteUser(int[] users)
        {
            if (IsUserAdmin(User.Identity.Name)) //如果Token权限为Admin
            {
                try
                {
                    await ClearUserData(users);
                    foreach (int i in users)
                    {
                        _context.Users.Remove(_context.Users.Find(i));
                    }
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                catch
                {
                    return new Response(0);
                }
            }
            else
            {
                return new Response(0);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> ResetUserPwd(int[] users, string password)
        {
            if (IsUserAdmin(User.Identity.Name)) //如果Token权限为Admin
            {
                try
                {
                    foreach (int i in users)
                    {
                        (await _context.Users.FindAsync(i)).UserPwd = password;
                    }
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                catch
                {
                    return new Response(0);
                }
            }
            else
            {
                return new Response(0);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> ClearUserData(int[] users)
        {
            if (IsUserAdmin(User.Identity.Name)) //如果Token权限为Admin
            {
                try
                {
                    foreach (int i in users)
                    {
                        _context.Accounts.RemoveRange(_context.Accounts.Where(j => j.Id == i));
                        _context.Categories.RemoveRange(_context.Categories.Where(j => j.Id == i));
                        _context.Records.RemoveRange(_context.Records.Where(j => j.Id == i));
                    }
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                catch
                {
                    return new Response(0);
                }
            }
            else
            {
                return new Response(0);
            }
        }





    }
}
