using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class RatingModel
    {
        [Required]
        public int restaurantID { get; set; }
        [Required]
        public int restaurantName { get; set; }
        public int averageRating { get; set; }

    }
}