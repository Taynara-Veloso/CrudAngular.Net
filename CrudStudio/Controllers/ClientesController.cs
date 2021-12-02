using System.Collections.Generic;
using System.Threading.Tasks;
using CrudStudio.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudStudio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly Contexto _contexto;

        public ClientesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>>PegarTodosAsync(){
            return await _contexto.Clientes.ToListAsync();
        }
        [HttpGet ("{ID}")]
        public async Task<ActionResult<Cliente>> PegarIdAsync(int? ID){
            Cliente cliente = await _contexto.Clientes.FindAsync(ID);

            if(ID == null){
                return NotFound();
            }
            return cliente;
        }
        [HttpPost]
        public async Task<ActionResult<Cliente>> SalvarClienteAsync(Cliente cliente){
            await _contexto.Clientes.AddAsync(cliente);
            await _contexto.SaveChangesAsync();

            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> AtualizarClienteAsync(Cliente cliente){
            _contexto.Clientes.Update(cliente);
            await _contexto.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete ("{ID}")]
        public async Task<ActionResult> ExcluirClienteAsync(int ID){
            Cliente cliente = await _contexto.Clientes.FindAsync(ID);
            if(cliente == null){
                return NotFound();
            }
            _contexto.Remove(cliente);
            await _contexto.SaveChangesAsync();
            return Ok();
        }
    }
}
