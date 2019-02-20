using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class CommentModel
    {
        public int commentID { get; set; }
        [Required]
        public string userComment { get; set; }
        [Required]
        public int userID { get; set; }
        [Required]
        public int restaurantID { get; set; }
    }
}