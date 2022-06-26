using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public class InputWatcher : ComponentBase
    {
        private EditContext _editContext = default!;

        public EditContext EditContext
        {
            get => _editContext;
            set 
            { 
                _editContext = value;
                EditContext.OnFieldChanged += async (sender, e) => 
                {
                    await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
                };
            }
        }

        [Parameter]
        public EventCallback<string> FieldChanged { get; set; }

        public bool Validate() => EditContext?.Validate() ?? false;
    }
}
