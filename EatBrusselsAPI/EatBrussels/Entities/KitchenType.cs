using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class KitchenType
    {
        [Key]
        public int KitchenTypeID { get; set; }
        public string KitchenLabel { get; set; }
    }
}