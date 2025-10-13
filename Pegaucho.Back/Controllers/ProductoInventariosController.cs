using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pegaucho.Back.Data;
using Pegaucho.Shared.Entities;

namespace Pegaucho.Back.Controllers
{
    [ApiController]
    [Route("api/productoinventario")]
    public class ProductoInventariosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductoInventariosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get() 
        {
            return Ok(await _context.ProductoInventarios.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var productoInventario = await _context.ProductoInventarios.FirstOrDefaultAsync(x => x.Id == id);
            if (productoInventario == null)
            {
                return NotFound();
            }
            return Ok(productoInventario);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductoInventario productoInventario)
        {
            _context.ProductoInventarios.Add(productoInventario);
            await _context.SaveChangesAsync();
            return Ok(productoInventario);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ProductoInventario productoInventario) 
        {
            _context.ProductoInventarios.Update(productoInventario);

            await _context.SaveChangesAsync();
            return Ok(productoInventario);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasafectadas = await _context.ProductoInventarios
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
            if (filasafectadas== 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
