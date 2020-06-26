using Microsoft.AspNetCore.Components;

namespace Arinsys.AspNetCore.Components.Bootstrap.Content
{
    public partial class Table<TEntity, TColumnDefinition, TTableDataFilters> : Components.Content.Table<TEntity, TColumnDefinition, TTableDataFilters>
        where TColumnDefinition : Components.Content.ColumnDefinition<TEntity>
        where TTableDataFilters : Components.Content.TableDataFilters<TEntity>
    {
        public Table()
        {
            ComponentCssClasses.Add("table");
        }
    }
}
