using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerAPI.Data;
using System.Collections;
using DockerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DockerAPIContext _context;
        public MoviesController(DockerAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable>> GetMovie()
        {
            return await _context.Movies.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Movies>> PostMovie(Movies movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.ID }, movie);
        }
    }
}
