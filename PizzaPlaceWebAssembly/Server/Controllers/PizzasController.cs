using Microsoft.AspNetCore.Mvc;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Server.Controllers
{
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaPlaceDbContext _dbContext;

        public PizzasController(PizzaPlaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("/pizzas2")]
        public IList<Pizza> GetPizzas()
        {
            return _dbContext.Pizzas.ToList();
        }

        [HttpPost("/pizzas")]
        public IActionResult InsertPizza([FromBody] Pizza pizza)
        {
            _dbContext.Add(pizza);
            _dbContext.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
    }
}
