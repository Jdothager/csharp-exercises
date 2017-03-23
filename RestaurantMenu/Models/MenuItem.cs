using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class MenuItem
    {
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public bool newItem { get; set; }
    }
}
