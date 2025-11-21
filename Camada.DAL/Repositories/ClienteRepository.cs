

using Camada.DAL.Context;
using Camada.Model;

namespace Camada.DAL.Repositories
{

    public class ClienteRepository
    {
        private readonly CamadaContext _context;

        public ClienteRepository(CamadaContext context)
        {
            _context = context;
        }

        public bool Cadastrar(Cliente c)
        {
            _context.Clientes.Add(c);
            return _context.SaveChanges() > 0;
        }

        public List<Cliente> ObterTodos()
        {
            var lista = _context.Clientes.ToList();
            return lista;
        }

        public Cliente? ObterPorId(long id)
        {
            var cliente = _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
            return cliente;
        }
    }
}
