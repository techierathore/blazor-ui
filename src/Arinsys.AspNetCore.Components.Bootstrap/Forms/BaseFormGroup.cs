using Microsoft.AspNetCore.Components;

namespace Arinsys.AspNetCore.Components.Bootstrap.Forms
{
    public abstract class BaseFormGroup<TValue> : Components.Forms.BaseFormGroup<TValue>
    {
        [Parameter]
        public GridColumnSpan GridColumnSpan { get; set; } = GridColumnSpan.Auto;
    }
}
