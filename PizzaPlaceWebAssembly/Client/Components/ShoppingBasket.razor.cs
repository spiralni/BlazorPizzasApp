using Microsoft.AspNetCore.Components;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;

        [Parameter]
        public EventCallback<int> OnRemoveItem { get; set; }

        [Parameter]
        public Func<int, Pizza> GetPizzaById { get; set; } = default!;

        private IEnumerable<(Pizza pizza, int pos)> Pizzas { get; set; } = default!;

        private decimal TotalPrice { get; set; } = default!;

        protected override void OnParametersSet()
        {
            Pizzas = Orders.Select((id, pos) => (pizza: GetPizzaById(id), pos: pos));
            TotalPrice = Pizzas.Select(tuple => tuple.pizza.Price).Sum();
            base.OnParametersSet();
        }
    }
}
