﻿using Microsoft.AspNetCore.Components;

namespace PizzaPlaceWebAssembly.Client.Components
{
    public partial class ItemList<TItem>
    {
        [Parameter]
        public RenderFragment Header { get; set; } = default!;

        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; } = default!;

        [Parameter]
        public RenderFragment Footer { get; set; } = default!;

        [Parameter]
        public IEnumerable<TItem> Items { get; set; } = default!;
    }
}
