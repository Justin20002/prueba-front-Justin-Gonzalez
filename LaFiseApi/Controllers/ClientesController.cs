using Microsoft.AspNetCore.Mvc;


using LaFiseApi_.Data;
using LaFiseApi_.Models;

namespace LaFiseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly LaFiseDbContext context;
        private object _context;
        private object _Context;

        public ClienteController(LaFiseDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CrearCliente([FromBody] Cliente Cliente)
        {
            object value = _Context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(ObtenerCliente), new { id = Cliente.Id }); _ = Cliente;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerCliente(int id)
        {
            var Cliente = await _Context.Cliente.Include(c => c.Cuentas)
                                    .FirstOrDefaultAsync(c => c.Id == id);
            if (Cliente == null)
                return NotFound();
            return Ok(Cliente);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos(object cliente)
        {
            var Cliente = await _Context.Cliente.include(c => c.Cuentas).ToListAsync();
            return Ok(liente);
        }

        }


}
