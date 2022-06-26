using Microsoft.AspNetCore.Components;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public partial class PizzaItem
    {
        [Parameter]
        public Pizza Pizza { get; set; } = default!;

        [Parameter]
        public EventCallback<Pizza> OnPizzaSelected { get; set; } = default!;

        private string GetSpicyImage(Spiciness spiciness) => $"images/{spiciness.ToString().ToLower()}.jpg";
    }
}
