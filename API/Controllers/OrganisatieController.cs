using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wtb.Domain;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class OrganisatieController : Controller
    {
        private readonly DataContext _context;

        public OrganisatieController(DataContext context)
        {
            _context = context;    
        }
    

         // GET: Organisaties
        [HttpGet("All")]
        public async Task<ActionResult<IList<Organization>>> GetOrganisaties()
        {
            var orgs = await _context.GetOrganizationsAsync();
            
            return orgs;
        }
        
    }
}