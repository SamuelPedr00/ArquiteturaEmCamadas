
using Camada.DAL.Repositories;
using Camada.Model;

namespace Camada.BLL
{
    public class ClienteService
    {

        private readonly ClienteRepository _clienteRepository;
        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }

        public bool CadastrarCliente(Cliente c)
        {
            var result = _clienteRepository.Cadastrar(c);
            return result;
        }

        public List<Cliente> ObterTodos() { 
            var result = _clienteRepository.ObterTodos();
            return result;
        
        }
    }
}
