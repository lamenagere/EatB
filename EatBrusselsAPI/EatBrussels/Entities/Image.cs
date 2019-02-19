using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public int RestaurantID { get; set; }
        public string ImageUrl { get; set; }
    }
}