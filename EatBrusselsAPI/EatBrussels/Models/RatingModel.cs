using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class RatingModel
    {
        public int restaurantID { get; set; }
        public int restaurantName { get; set; }
        public float averageRating { get; set; }
    }
}