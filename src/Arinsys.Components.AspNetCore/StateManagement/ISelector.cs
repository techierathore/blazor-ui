using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinsys.Components.AspNetCore.StateManagement
{
    public interface ISelector<TState> { }
    public interface ISelector<TState, TProjection> : ISelector<TState>
    {
        Func<TState, TProjection> Projection { get; }
    }
}
