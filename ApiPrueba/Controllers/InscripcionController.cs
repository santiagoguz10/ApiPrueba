using ApiPrueba.Context;
using ApiPrueba.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public InscripcionController(ApiDbContext contexto)
        {
            _context = contexto;
        }

        //Peticion tipo GET: api/Inscripcion

        [HttpGet]
        [Produces("Application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Solicitud_Ingreso))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Solicitud_Ingreso>>> GetSolicitud()
        {
            return await _context.Solicitud.ToListAsync();
        }

        [HttpGet("{id}")]
        [Produces("Application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Solicitud_Ingreso))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Solicitud_Ingreso>> GetSolicitudId(int id)
        {
            var solicitudItem = await _context.Solicitud.FindAsync(id);

            if (solicitudItem == null)
            {
                return NotFound();
            }

            return solicitudItem;
        }

        [HttpPost]
        [Produces("Application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Solicitud_Ingreso))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Solicitud_Ingreso>> PostSolicitudItem(Solicitud_Ingreso item)
        {
            _context.Solicitud.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSolicitudId), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        [Produces("Application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Solicitud_Ingreso))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutSolicitudItem(int id, Solicitud_Ingreso item)
        {
           
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Produces("Application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Solicitud_Ingreso))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteSolicitudItem(int id)
        {
            var solicitudItem = await _context.Solicitud.FindAsync(id);

            if (solicitudItem == null)
            {
                return NotFound();
            }

            _context.Solicitud.Remove(solicitudItem);
            await _context.SaveChangesAsync();

            return NoContent();

        }

    }
}
