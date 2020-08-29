using System.Collections.Generic;
using System.Linq;

namespace Arinsys.Components.AspNetCore
{
    public class NavItem
    {
        private bool isSelected;

        public string Path { get; set; }
        public string Text { get; set; }
        public string IconClass { get; set; }
        public bool IsSelected { get => isSelected || SubNavItems.Any(x => x.IsSelected); set => isSelected = value; }

        public List<NavItem> SubNavItems { get; set; } = new List<NavItem>();
    }
}
