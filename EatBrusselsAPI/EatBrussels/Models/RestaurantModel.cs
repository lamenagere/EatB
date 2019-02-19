using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class RestaurantModel
    {
        public int restaurantID { get; set; }
        public string name { get; set; }
        public string kitchenType { get; set; }
        public string address { get; set; }
        public string openingHours { get; set; }
        public string closingHours { get; set; }
        public string description { get; set; }
    }
}