using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorQRCode.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class D2AthletesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public D2AthletesController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var athletes =  await _context.D2Athletes.ToListAsync();
            return Ok(athletes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.D2Athletes.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(D2Athlete d2athlete)
        {
            _context.Add(d2athlete);
            await _context.SaveChangesAsync();
            return Ok(d2athlete.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(D2Athlete d2athlete)
        {
            _context.Entry(d2athlete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new D2Athlete { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
