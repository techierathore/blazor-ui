using Arinsys.AspNetCore.Components.Forms;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arinsys.AspNetCore.Components.Bootstrap.Forms
{
    public partial class FormGroupText : BaseFormGroup<string>
    {
        [Parameter]
        public string InputPrepend { get; set; }

        [Parameter]
        public string InputAppend { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        private async Task OnValueChanged(ChangeEventArgs eventArgs)
        {
            await ValueChanged.InvokeAsync(eventArgs.Value.ToString());
            CascadedEditContext.Validate();
        }
    }
}
