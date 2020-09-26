namespace Arinsys.Components.AspNetCore.Bootstrap.Forms
{
    public partial class Form<TEntity, TFormDefinition> : AspNetCore.Forms.Form<TEntity, TFormDefinition>
        where TFormDefinition : AspNetCore.Forms.FormDefinition<TEntity>
    {
    }
}
