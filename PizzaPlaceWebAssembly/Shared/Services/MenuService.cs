using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWebAssembly.Shared.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _httpClient;

        public MenuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async ValueTask<Menu> GetMenuAsync()
        {
            var pizzas = await _httpClient.GetFromJsonAsync<Pizza[]>("/pizzas2");

            return new Menu {
                Pizzas = pizzas!.ToList()
            };
        }
    }
}
