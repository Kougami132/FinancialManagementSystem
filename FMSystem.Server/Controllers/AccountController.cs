using FMSystem.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMSystem.Server.Controllers
{
    [ApiController]
    [Route("Api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly FMContext _context;

        public AccountController(FMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Account> GetAccount()
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                IEnumerable<Account> result = _context.Accounts.Where(i => _context.Users.First(j => j.Id == i.User).UserName == User.Identity.Name);
                return result;
            }
            else
            {
                return new Account[0];
            }
        }

        [HttpGet]
        public ActionResult<Response> IsAccountExist(string name)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    if (_context.Accounts.Any(i => i.Name.ToLower() == name.ToLower() && _context.Users.First(j => j.Id == i.User).UserName == User.Identity.Name))
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
            else
            {
                return new Response(0);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddAccount(Account newAccount)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                if (_context.Users.Find(newAccount.User).UserName == User.Identity.Name)
                {
                    await _context.Accounts.AddAsync(newAccount);
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                else
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
        public async Task<ActionResult<Response>> EditAccount(Account editAccount)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                if (_context.Users.Find(editAccount.User).UserName == User.Identity.Name)
                {
                    _context.Accounts.Update(editAccount);
                    await _context.SaveChangesAsync();
                    return new Response(1);
                }
                else
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
        public async Task<ActionResult<Response>> DeleteAccount(int[] accounts)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    foreach (int i in accounts)
                    {
                        if (_context.Users.Find(_context.Accounts.Find(i).User).UserName == User.Identity.Name)
                        {
                            _context.Accounts.Remove(await _context.Accounts.FindAsync(i));
                        }
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
