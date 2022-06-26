namespace PizzaPlaceWebAssembly.Shared
{
    public class Menu
    {
        public Menu()
        {
            Pizzas = new List<Pizza>();
        }

        public IList<Pizza> Pizzas { get; set; }

        public void Add(Pizza pizza) => Pizzas.Add(pizza);

        public Pizza? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
