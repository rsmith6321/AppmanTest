using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalTest.Data;
using FinalTest.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {

        private readonly relationContext _context;

        public UniversitiesController(relationContext context)
        {
            _context = context;
        }

        // GET: api/<UniversitiesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> GetUniversities()
        {
            return await _context.Universities.ToListAsync();
        }

        // GET api/<UniversitiesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UniversitiesController>
        public async Task<ActionResult<University>> PostUniversity(University university)
        {
            _context.Universities.Add(university);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = university.Id }, university);
        }

        // PUT api/<UniversitiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UniversitiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
