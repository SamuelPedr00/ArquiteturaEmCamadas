using Camada.BLL;
using Camada.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Camada.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult GetClientes() {
            var listaCliente = _clienteService.ObterTodos();

            return Ok(listaCliente);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente([FromRoute] int id)
        {
            var cliente = _clienteService.ObterPorId(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]

        public IActionResult CadastrarCliente([FromBody] Cliente param )
        {
            var result = _clienteService.CadastrarCliente(param);

            if(result == true)
            {
                return Ok("Cliente cadastrado com sucesso");
            }

            return BadRequest("Erro ao cadastrar cliente");
        }

        [HttpPut]

        public IActionResult Atualizar([FromBody] Cliente param)
        {
            var result = _clienteService.Atualizar(param);

            if (result == true)
            {
                return Ok("Cliente atualizado com sucesso");
            }

            return BadRequest("Erro ao atualizar cliente");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCliente([FromRoute] int id)
        {
            var result = _clienteService.DeletarCliente(id);
            if (result == true)
            {
                return Ok("O cliente foi deletado com sucesso");

            }
            return BadRequest("Erro ao deletar cliente");

        }

    }
}
