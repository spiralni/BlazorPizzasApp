using Microsoft.AspNetCore.Mvc;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaPlaceDbContext _dbContext;

        public PizzasController(PizzaPlaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private static readonly List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy ),
            new Pizza(2, "Margarita", 7.99M, Spiciness.None ),
            new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot )
        };

        [HttpGet("/")]
        public IQueryable<Pizza> GetPizzas()
        {
            return _dbContext.Pizzas;
        }

        [HttpPost("/")]
        public IActionResult InsertPizza([FromBody] Pizza pizza)
        {
            _dbContext.Add(pizza);
            _dbContext.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
    }
}
