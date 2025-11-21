

using Camada.Model;

namespace Camada.DAL.Repositories
{
    public class ClienteRepository
    {
        public ClienteRepository()
        {
            
        }

        public bool Cadastrar(Cliente c)
        {
            return true;
        }

        public List<Cliente> ObterTodos() {
            var lista = new List<Cliente>()
            {
                new Cliente {
                    Id = 1,
                    Nome = "Samuel",
                    Idade = 20,
                    Nascimento = new DateTime(2004, 1, 1)

                },
                new Cliente {
                    Id = 2,
                    Nome = "Gabriel",
                    Idade = 16,
                    Nascimento = new DateTime(2009, 1, 1)

                }
            };
            return lista;
        }
    }
}
