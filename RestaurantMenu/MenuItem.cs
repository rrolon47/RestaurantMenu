using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private double Price { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }
        private bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;

        }
    }
}
