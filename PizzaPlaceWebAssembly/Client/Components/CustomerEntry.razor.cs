using Microsoft.AspNetCore.Components;
using PizzaPlaceWebAssembly.Shared;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public partial class CustomerEntry
    {
        private bool _isInvalid = true;
        
        private InputWatcher _inputWatcher = default!;

        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public Customer Customer { get; set; } = default!;

        [Parameter]
        public EventCallback OnPlaceOrder { get; set; }

        [Parameter]
        public EventCallback<Customer> CustomerChanged { get; set; }

        private void FieldChanged(string fieldName)
        {
            CustomerChanged.InvokeAsync(Customer);
            _isInvalid = !_inputWatcher.Validate();
        }
    }
}
