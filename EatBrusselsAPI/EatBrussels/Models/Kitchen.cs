using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class Kitchen
    {
        [Key]
        public int KitchenID { get; set; }
        public int RestaurantID { get; set; }
        

    }
}