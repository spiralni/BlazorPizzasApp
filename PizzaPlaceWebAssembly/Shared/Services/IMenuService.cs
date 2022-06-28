using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWebAssembly.Shared.Services
{
    public interface IMenuService
    {
        ValueTask<Menu> GetMenuAsync();
    }
}
