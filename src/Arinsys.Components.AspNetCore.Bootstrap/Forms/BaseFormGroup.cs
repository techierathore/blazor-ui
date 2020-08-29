using Microsoft.AspNetCore.Components;

namespace Arinsys.Components.AspNetCore.Bootstrap.Forms
{
    public abstract class BaseFormGroup<TValue> : AspNetCore.Forms.BaseFormGroup<TValue>
    {
        [Parameter]
        public GridColumnSpan GridColumnSpan { get; set; } = GridColumnSpan.Auto;
    }
}
