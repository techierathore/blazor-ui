namespace Arinsys.Components.AspNetCore.Bootstrap.Tables
{
    public partial class Table<TEntity, TColumnDefinition, TTableDataFilters> : AspNetCore.Tables.Table<TEntity, TColumnDefinition, TTableDataFilters>
        where TColumnDefinition : AspNetCore.Tables.ColumnDefinition<TEntity>
        where TTableDataFilters : AspNetCore.Tables.TableDataFilters<TEntity>, new()
    {
        public Table()
        {
            ComponentCssClasses.Add("table");
        }
    }
}
