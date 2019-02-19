using EatBrussels.Entities;
using EatBrussels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatBrussels.Mapper
{
    public static class Mapper
    {
        public static Restaurant ConvertModelToRestaurant (this RestaurantModel restaurant)
        {
            return new Restaurant()
            {
                Name = restaurant.name,
                Address = restaurant.address,
                ZipCode = restaurant.zipCode,
                OpeningHour = restaurant.openingHour,
                ClosingHour = restaurant.closingHour
            };
        }
    }
}