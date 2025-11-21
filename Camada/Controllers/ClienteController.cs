using Camada.BLL;
using Camada.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Camada.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;
        public ClienteController()
        {
            _clienteService = new ClienteService();
        }

        [HttpGet]
        public IActionResult GetClientes() {
            var listaCliente = _clienteService.ObterTodos();

            return Ok(listaCliente);
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
    }
}
