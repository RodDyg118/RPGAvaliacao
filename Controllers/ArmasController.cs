using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RpgApi.Data;
using RpgApi.Models;
using RPGAPI.Models;

namespace RPGAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]

public class ArmasController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmasController(DataContext context)
        {

            _context = context;
        }

        

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Armas> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost]
        public async Task<IActionResult> Add(Armas novoArmas)
        {
            try
            {
                if (novoArmas.Dano > 150)
                {
                    throw new Exception("Pontos de Vida muito altos para este personagem ser criado!");
                }

                await _context.TB_ARMAS.AddAsync(novoArmas);
                await _context.SaveChangesAsync();
                return Ok (novoArmas.Id);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
}
}