using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime Updated { get; }

        public Menu(DateTime updated, List<MenuItem> menuItems)
        {
            Updated = updated;
            MenuItems = menuItems;
        }
    }
}
