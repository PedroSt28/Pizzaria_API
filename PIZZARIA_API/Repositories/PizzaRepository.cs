using PIZZARIA_API.Contexts;
using PIZZARIA_API.Interfaces;
using PIZZARIA_API.Models;

namespace PIZZARIA_API.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {

        private readonly PizzariaContext _context;
        public PizzaRepository(PizzariaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Pizza pizza)
        {
            _context.Pizza.Add(pizza);
            _context.SaveChanges();
        }

        public List<Pizza> ListarTodos()
        {
            return _context.Pizza.ToList();
        }
    }
}


// Parei na linha 10!!!!