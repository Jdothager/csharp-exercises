using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class Menu
    {
        private DateTime lastModified;
        private MenuItem item;

        public DateTime LastModified
        {
            get { return lastModified; }
            set { lastModified = DateTime.Now; }
        }

        public MenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
