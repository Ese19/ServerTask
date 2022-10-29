using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ServerTask.Data;

namespace ServerTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public InfoController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {  
                 var result = await appDbContext.Infos.ToListAsync();
                 return Ok(result[0]);
            }  
            catch (Exception)
            {      
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }  
        }
    }
}