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
    public class RecordController : Controller
    {

        private readonly FMContext _context;

        public RecordController(FMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Record> GetRecord()
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                return _context.Records.Where(i => i.User == User.Identity.Name);
            }
            else
            {
                return new Record[0];
            }
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddRecord(Record newRecord)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    await _context.Records.AddAsync(newRecord);
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
        public async Task<ActionResult<Response>> EditRecord(Record editRecord)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    _context.Records.Update(editRecord);
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
        public async Task<ActionResult<Response>> DeleteRecord(int[] records)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    foreach (int i in records)
                    {
                        _context.Records.Remove(await _context.Records.FindAsync(i));
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
