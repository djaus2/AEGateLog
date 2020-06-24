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
    public class DAthletesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public DAthletesController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var athletes =  await _context.DAthletes.ToListAsync();
            return Ok(athletes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.DAthletes.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DAthlete dathlete)
        {
            _context.Add(dathlete);
            await _context.SaveChangesAsync();
            return Ok(dathlete.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DAthlete dathlete)
        {
            _context.Entry(dathlete).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new DAthlete { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
