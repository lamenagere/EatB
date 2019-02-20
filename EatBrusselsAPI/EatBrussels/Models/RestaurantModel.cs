using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class RestaurantModel
    {
        [Required]
        public int restaurantID { get; set; }
        [Required]
        public string name { get; set; }
        public string imageUrl { get; set; }
        [Required]
        public string kitchenType { get; set; }
        [Required]
        public string address { get; set; }
        public string openingHour { get; set; }
        public string closingHour { get; set; }
        public string description { get; set; }
        [Required]
        public string zipCode { get; set; }
        public int averageRating { get; set; }
    }
}