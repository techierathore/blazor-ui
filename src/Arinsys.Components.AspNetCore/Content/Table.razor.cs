using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Reactive.Linq;

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
        where TTableDataFilters : TableDataFilters<TEntity>
    {
        [Parameter]
        public IEnumerable<TColumnDefinition> ColumnDefinitions { get; set; }

        [Parameter]
        public virtual IObservable<IEnumerable<TEntity>> DataObservable { get; set; }

        [Parameter]
        public virtual Func<TTableDataFilters, IEnumerable<TEntity>> DataAccessor { get; set; }

        [Parameter]
        public RenderFragment<TEntity> Body { get; set; }

        [Parameter]
        public RenderFragment LoadingContent { get; set; }

        protected IEnumerable<TEntity> Data { get; private set; }
        protected TTableDataFilters Filters { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (DataAccessor != null) Data = DataAccessor(Filters);
            if (DataObservable != null) ChangeStateOn(DataObservable?.Do(data => Data = data));
        }
    }
}
