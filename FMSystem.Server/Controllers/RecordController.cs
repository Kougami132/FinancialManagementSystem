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
                return _context.Records.Where(i => _context.Users.First(j => j.Id == i.User).UserName == User.Identity.Name);
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
                if (_context.Users.Find(newRecord.User).UserName == User.Identity.Name)
                {
                    await _context.Records.AddAsync(newRecord);
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
        public async Task<ActionResult<Response>> EditRecord(Record editRecord)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                if (_context.Users.Find(editRecord.User).UserName == User.Identity.Name)
                {
                    _context.Records.Update(editRecord);
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
        public async Task<ActionResult<Response>> DeleteRecord(int[] records)
        {
            if (Tools.IsUserExist(_context, User.Identity.Name)) //如果Token用户存在
            {
                try
                {
                    foreach (int i in records)
                    {
                        if (_context.Users.Find(_context.Records.Find(i).User).UserName == User.Identity.Name)
                        {
                            _context.Records.Remove(await _context.Records.FindAsync(i));
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
