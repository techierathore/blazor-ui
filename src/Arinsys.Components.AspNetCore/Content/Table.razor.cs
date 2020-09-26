using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace Arinsys.Components.AspNetCore.Content
{
    public class ColumnDefinition<TEntity>
    {
        public string Label { get; set; }
        public Func<TEntity, object> Accessor { get; set; }
    }

    public class TableDataFilters<TEntity>
    {

    }

    public partial class Table<TEntity, TColumnDefinition, TTableDataFilters> : BaseComponent
        where TColumnDefinition : ColumnDefinition<TEntity>
        where TTableDataFilters : TableDataFilters<TEntity>, new()
    {
        internal readonly BehaviorSubject<object> filtersObservable = new BehaviorSubject<object>(null);

        [Parameter]
        public IEnumerable<TColumnDefinition> ColumnDefinitions { get; set; }

        [Parameter]
        public virtual Func<TTableDataFilters, Task<IEnumerable<TEntity>>> DataAccessor { get; set; }

        [Parameter]
        public RenderFragment<TEntity> Body { get; set; }

        [Parameter]
        public RenderFragment HeadContent { get; set; }

        [Parameter]
        public RenderFragment LoadingContent { get; set; }

        public IObservable<TTableDataFilters> FiltersObservable => filtersObservable.Select(_ => TableDataFilters);
        public TTableDataFilters TableDataFilters { get; private set; } = new TTableDataFilters();
        public void TableDataFiltersUpdated() => filtersObservable.OnNext(null);


        protected IEnumerable<TEntity> Data { get; private set; }
        protected TTableDataFilters Filters { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (DataAccessor != null) Data = await DataAccessor(Filters);
        }
    }
}
