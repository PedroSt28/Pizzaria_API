using PIZZARIA_API.Models;

namespace PIZZARIA_API.Interfaces
{
    public interface IPizzaRepository
    {
        //devolve a lista de pizzas
        List<Pizza> ListarTodos();

        //cria uma piza
        void Cadastrar(Pizza pizza); 
    }
}
