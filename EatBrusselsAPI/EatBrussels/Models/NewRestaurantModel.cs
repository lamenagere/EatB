using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class NewRestaurantModel
    {
        public int restaurantID { get; set; }
        [Required]
        public string name { get; set; }
        public List<string> images { get; set; }
        [Required]
        public List<int> kitchenTypes { get; set; }
        [Required]
        public string address { get; set; }
        public string openingHour { get; set; }
        public string closingHour { get; set; }
        public string description { get; set; }
        [Required]
        public string zipCode { get; set; }
    }
}