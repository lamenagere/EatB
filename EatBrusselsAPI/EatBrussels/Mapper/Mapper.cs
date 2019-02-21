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
        /// <summary>
        /// RestaurantModel to Restaurant
        /// </summary>
        /// <param name="restaurantModel"></param>
        /// <returns></returns>
        public static Restaurant ConvertModelToRestaurant (this NewRestaurantModel restaurantModel)
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

        /// <summary>
        /// Restaurant to RestaurantModel
        /// </summary>
        /// <param name="restaurant"></param>
        /// <param name="kitchenLabel"></param>
        /// <param name="imageUrl"></param>
        /// <param name="averageRating"></param>
        /// <returns></returns>
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

        /// <summary>
        /// RestaurantModel to Image
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        public static IEnumerable<Image> ConvertModelToImages (this NewRestaurantModel restaurant, int restaurantID)
        {
            return restaurant.images.Select(i => new Image() { ImageUrl = i, RestaurantID = restaurantID });
        }

        /// <summary>
        /// RestaurantModel to kitchenType
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        public static IEnumerable<Kitchen> ConvertModelToKitchen (this NewRestaurantModel restaurant, int restaurantID)
        {
            return restaurant.kitchenTypes.Select(k => new Kitchen() { KitchenTypeID = k, RestaurantID = restaurantID });
        }

        /// <summary>
        /// CommentModel to Comment
        /// </summary>
        /// <param name="commentModel"></param>
        /// <returns></returns>
        public static Comment ConvertToComment(this CommentModel commentModel)
        {
            return new Comment()
            {
                CommentID = commentModel.commentID,
                RestaurantID = commentModel.restaurantID,
                UserComment = commentModel.userComment,
                UserID = commentModel.userID
            };
        }

        /// <summary>
        /// CommentModel to Comment
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static CommentModel ConvertToCommentModel(this Comment comment)
        {
            return new CommentModel()
            {
                commentID = comment.CommentID,
                restaurantID = comment.RestaurantID,
                userComment = comment.UserComment,
                userID = comment.UserID
            };
        }
    }
}