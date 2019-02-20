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
        public static Restaurant ConvertModelToRestaurant (this RestaurantModel restaurantModel)
        {
            return new Restaurant()
            {
                RestaurantID = restaurantModel.restaurantID,
                Name = restaurantModel.name,
                Address = restaurantModel.address,
                ZipCode = restaurantModel.zipCode,
                OpeningHour = restaurantModel.openingHour,
                ClosingHour = restaurantModel.closingHour,
                Description = restaurantModel.description
            };
        }

        public static RestaurantModel ConvertRestaurantToModel (this Restaurant restaurant, string kitchenLabel, string imageUrl, int averageRating)
        {
            return new RestaurantModel()
            {
                restaurantID = restaurant.RestaurantID,
                name = restaurant.Name,
                address = restaurant.Address,
                zipCode = restaurant.ZipCode,
                openingHour = restaurant.OpeningHour,
                closingHour = restaurant.ClosingHour,
                description = restaurant.Description,
                kitchenType = kitchenLabel,
                imageUrl = imageUrl,
                averageRating = averageRating
            };
        }

    }
}