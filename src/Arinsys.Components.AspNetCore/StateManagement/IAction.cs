using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arinsys.Components.AspNetCore.StateManagement
{
    /// <summary>Identifies a class that is used to perform specific action</summary>
    /// <typeparam name="TState">The class type of the state this action corresponds to</typeparam>
    public interface IAction<TState> { }
}
