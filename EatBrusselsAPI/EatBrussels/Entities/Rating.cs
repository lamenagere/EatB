using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public int Rate { get; set; }
    }
}