
using Camada.DAL.Repositories;
using Camada.Model;

namespace Camada.BLL
{
    public class ClienteService
    {

        private readonly ClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository repository)
        {
            _clienteRepository = repository;
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
        public Cliente? ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public bool Atualizar(Cliente c)
        {
            var cliente = _clienteRepository.ObterPorId(c.Id);

            if (cliente == null)
            {
                return false;
            }

            cliente.Nome = c.Nome;
            cliente.Nascimento = c.Nascimento;
            cliente.Idade = c.Idade;
            return _clienteRepository.Atualizar(cliente);
        }

        public bool DeletarCliente(int Id)
        {
            var cliente = _clienteRepository.ObterPorId(Id);

            if (cliente == null)
            {
                return false;
            }

            return _clienteRepository.Deletar(cliente);
        }
    }
}
