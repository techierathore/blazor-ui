namespace Arinsys.Components.AspNetCore.Bootstrap.Content
{
    public partial class Table<TEntity, TColumnDefinition, TTableDataFilters> : AspNetCore.Content.Table<TEntity, TColumnDefinition, TTableDataFilters>
        where TColumnDefinition : AspNetCore.Content.ColumnDefinition<TEntity>
        where TTableDataFilters : AspNetCore.Content.TableDataFilters<TEntity>
    {
        public Table()
        {
            ComponentCssClasses.Add("table");
        }
    }
}
