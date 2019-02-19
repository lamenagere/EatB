﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class Kitchen
    {
        [Key]
        public int KitchenID { get; set; }

        public int KitchenTypeID { get; set; }
        public int RestaurantID { get; set; }
    }
}