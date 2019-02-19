using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Entities
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string UserComment { get; set; }
        public int RestaurantID { get; set; }
        public int UserID { get; set; }
    }
}