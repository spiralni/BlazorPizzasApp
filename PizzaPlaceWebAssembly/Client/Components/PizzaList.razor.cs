using Microsoft.AspNetCore.Components;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public partial class PizzaList
    {
        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public IEnumerable<Pizza> Pizzas { get; set; } = default!;

        [Parameter]
        public EventCallback<Pizza> OnPizzaSelected { get; set; }
    }
}
