using Arinsys.Components.AspNetCore.StateManagement;

using System.Collections.Generic;

namespace Arinsys.Components.AspNetCore.Navigation
{
    public record BreadCrumbs(string HeadingText, List<BreadCrumbitem> BreadCrumbitems);
    public record BreadCrumbitem(string Text, string Path);

    public record UpdateBreadCrumbs(BreadCrumbs UpdatedBreadCrumbs) : IAction<BreadCrumbs>;

    public class UpdateBreadCrumbsReducer : Reducer<BreadCrumbs, UpdateBreadCrumbs>
    {
        public override BreadCrumbs Reduce(BreadCrumbs currentState, UpdateBreadCrumbs action)
        {
            return action.UpdatedBreadCrumbs;
        }
    }
}
