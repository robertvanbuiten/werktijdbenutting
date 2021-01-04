using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Wtb.Domain;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VraagController
    {
         private readonly DataContext _context;

        public VraagController(DataContext context)
        {
            _context = context;    
        }
        
        
        /*
        // GET: Organisaties
        [HttpGet("")]
        public async Task<ActionResult<IList<Demand>>> GetVragen()
        {
            return await _context..ToListAsync();
        }

         // GET: Organisaties
        [HttpGet("{straal}")]
        public async Task<ActionResult<IList<Vraag>>> GetVragenBinnenStraal(int straal)
        {
            return await _context.Vragen.ToListAsync();
        }
        */
    }
}