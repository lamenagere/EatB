using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatBrussels.Models
{
    public class CommentModel
    {
        public int commentID { get; set; }
        public string userComment { get; set; }
        public int userID { get; set; }
        public int restaurantID { get; set; }
    }
}