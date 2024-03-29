﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plants_Api.Contexts;
using Plants_Api.Models;

namespace Plants_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantDetailsController : ControllerBase
    {
        private readonly PlantsContext _context;

        public PlantDetailsController(PlantsContext context)
        {
            _context = context;
        }

        // GET: api/PlantDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlantDetails>>> GetPlantDetails()
        {
            return await _context.PlantDetails.ToListAsync();
        }

        // GET: api/PlantDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlantDetails>> GetPlantDetails(int id)
        {
            var plantDetails = await _context.PlantDetails.FindAsync(id);

            if (plantDetails == null)
            {
                return NotFound();
            }

            return plantDetails;
        }

        // PUT: api/PlantDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlantDetails(int id, PlantDetails plantDetails)
        {
            if (id != plantDetails.id)
            {
                return BadRequest();
            }

            _context.Entry(plantDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlantDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PlantDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlantDetails>> PostPlantDetails(PlantDetails plantDetails)
        {
            _context.PlantDetails.Add(plantDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlantDetails", new { id = plantDetails.id }, plantDetails);
        }

        // DELETE: api/PlantDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlantDetails(int id)
        {
            var plantDetails = await _context.PlantDetails.FindAsync(id);
            if (plantDetails == null)
            {
                return NotFound();
            }

            _context.PlantDetails.Remove(plantDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlantDetailsExists(int id)
        {
            return _context.PlantDetails.Any(e => e.id == id);
        }
    }
}
