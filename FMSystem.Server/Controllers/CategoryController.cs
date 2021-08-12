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
    public class CategoryController : Controller
    {
        private readonly FMContext _context;

        public CategoryController(FMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategory()
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                return _context.Categories.Where(i => i.User == User.Identity.Name);
            }
            else
            {
                return new Category[0];
            }
        }

        [HttpGet]
        public ActionResult<Response> IsCategoryExist(string name)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    if (_context.Categories.Any(i => i.Name.ToLower() == name.ToLower() && i.User == User.Identity.Name))
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
        public async Task<ActionResult<Response>> AddCategory(Category newCategory)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    await _context.Categories.AddAsync(newCategory);
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
        public async Task<ActionResult<Response>> EditCategory(Category editCategory)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    _context.Categories.Update(editCategory);
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
        public async Task<ActionResult<Response>> DeleteCategory(int[] Categorys)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    foreach (int i in Categorys)
                    {
                        _context.Categories.Remove(await _context.Categories.FindAsync(i));
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
