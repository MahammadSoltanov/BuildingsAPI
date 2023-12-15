using BuildingsAPI.Helpers;
using BuildingsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuildingsAPI.Controllers
{
    [Route("api/v1/buildings")]
    [ApiController]
    public class BuildingsController : Controller
    {

        private readonly MinaContext _context;

        public BuildingsController(MinaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBuildings()
        {
            var buildings = await _context.Binas.ToListAsync();

            return Ok(buildings.ToGeoJson()); 
        }
    }
}
