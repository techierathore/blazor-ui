namespace Arinsys.Components.AspNetCore.Bootstrap.Tables
{
    public partial class Table<TEntity, TTableDataFilters> : AspNetCore.Tables.Table<TEntity, TTableDataFilters>
        where TTableDataFilters : AspNetCore.Tables.TableDataFilters<TEntity>, new()
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            ComponentCssClasses.Add("table");
        }
    }
}
