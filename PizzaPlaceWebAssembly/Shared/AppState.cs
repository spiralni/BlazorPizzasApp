namespace PizzaPlaceWebAssembly.Shared
{
    public class AppState
    {
        public AppState()
        {
            Menu = new Menu();
            Basket = new ShoppingBasket();
            UI = new UI();
        }

        public Menu Menu { get; }

        public ShoppingBasket Basket { get; }

        public UI UI { get; set; }

        public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id)!.Price);
    }
}
