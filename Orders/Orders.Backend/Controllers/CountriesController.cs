﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;
        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if(country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async  Task<IActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id:int}")]

        public async Task<IActionResult> DeleteAsync(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            _context.Remove(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }
    }
}
