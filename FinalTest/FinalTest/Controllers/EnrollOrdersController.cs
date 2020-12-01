using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalTest.Models;
using FinalTest.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollOrdersController : ControllerBase
    {

        private readonly relationContext _context;

        public EnrollOrdersController(relationContext context)
        {
            _context = context;
        }


        // GET: api/<EnrollOrdersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnrollOrder>>> GetEnrollOrders()
        {
            return await _context.EnrollOrders.ToListAsync();
        }

        // GET api/<EnrollOrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnrollOrdersController>
        [HttpPost]
        public async Task<ActionResult<EnrollOrder>> PostEnrollOrders(EnrollOrder enrollOrder)
        {
            _context.EnrollOrders.Add(enrollOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = enrollOrder.StudentId }, enrollOrder);
        }

        // PUT api/<EnrollOrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnrollOrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
