using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Kitchen> Kitchens { get; set; }
    }
}