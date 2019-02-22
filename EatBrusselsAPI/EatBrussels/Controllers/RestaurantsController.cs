using EatBrussels.Entities;
using EatBrussels.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using EatBrussels.Mapper;
using System.Collections.Generic;

namespace EatBrussels.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RestaurantsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Restaurants    retourne tout les resto par rating décroissant
        [ResponseType(typeof(List<RestaurantModel>))]
        public async Task<IHttpActionResult> GetRestaurants()
        {
            var restaurantTemp = await (from r in db.Restaurants
                                        join kit in db.Kitchens on r.RestaurantID equals kit.RestaurantID
                                        join kt in db.KitchenTypes on kit.KitchenTypeID equals kt.KitchenTypeID
                                        join img in db.Images on r.RestaurantID equals img.RestaurantID into imgs
                                        from img in imgs.DefaultIfEmpty()
                                        join rt in db.Ratings on r.RestaurantID equals rt.RestaurantID into rates
                                        select (new
                                        {
                                            restaurant = r as Restaurant,
                                            kitchenType = kt.KitchenLabel,
                                            imageUrl = string.IsNullOrEmpty(img.ImageUrl) ? "" : img.ImageUrl,
                                            averageRating = rates.Count() > 0 ? (int)rates.Average(x => x.Rate) : 0
                                        })).Distinct().ToListAsync();

            List<RestaurantModel> result = restaurantTemp.Select(x => x.restaurant.ConvertRestaurantToModel(x.kitchenType, x.imageUrl, x.averageRating)).ToList();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Restaurants/5
        [ResponseType(typeof(RestaurantModel))]
        public IHttpActionResult GetRestaurant(int id)
        {
            var restaurantModel = (from r in db.Restaurants.AsParallel()
                                   join kit in db.Kitchens.AsParallel() on r.RestaurantID equals kit.RestaurantID
                                   join kt in db.KitchenTypes.AsParallel() on kit.KitchenTypeID equals kt.KitchenTypeID
                                   join img in db.Images.AsParallel() on r.RestaurantID equals img.RestaurantID into imgs
                                   from img in imgs.DefaultIfEmpty()
                                   join rt in db.Ratings.AsParallel() on r.RestaurantID equals rt.RestaurantID into rates
                                   where r.RestaurantID == id
                                   select r.ConvertRestaurantToModel(kt.KitchenLabel, img.ImageUrl, rates.Count() > 0 ? (int)rates.Average(x => x.Rate) : 0)).FirstOrDefault();


            if (restaurantModel == null)
            {
                return NotFound();
            }

            return Ok(restaurantModel);
        }

        // GET: api/Restaurants/type de cuisine
        [ResponseType(typeof(List<RestaurantModel>))]
        public async Task<IHttpActionResult> GetRestaurants(string kitchenType)
        {
            var restaurantTemp = await (from r in db.Restaurants
                                        join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
                                        join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
                                        join img in db.Images on r.RestaurantID equals img.RestaurantID into imgs
                                        from img in imgs.DefaultIfEmpty()
                                        join rt in db.Ratings on r.RestaurantID equals rt.RestaurantID into rates
                                        where kt.KitchenLabel == kitchenType
                                        select (new
                                        {
                                            restaurant = r as Restaurant,
                                            kitchenType = kt.KitchenLabel,
                                            imageUrl = img.ImageUrl,
                                            averageRating = rates.Count() > 0 ? (int)rates.Average(x => x.Rate) : 0
                                        })).Distinct().ToListAsync();

            List<RestaurantModel> result = restaurantTemp.Select(x => x.restaurant.ConvertRestaurantToModel(x.kitchenType, x.imageUrl, x.averageRating)).ToList();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Restaurants/code postal
        [ResponseType(typeof(List<RestaurantModel>))]
        public async Task<IHttpActionResult> GetRestaurantsByZipCode(string zipCode)
        {
            var restaurantTemp = await (from r in db.Restaurants
                                        join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
                                        join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
                                        join img in db.Images on r.RestaurantID equals img.RestaurantID into imgs
                                        from img in imgs.DefaultIfEmpty()
                                        join rt in db.Ratings on r.RestaurantID equals rt.RestaurantID into rates
                                        where r.ZipCode == zipCode
                                        select (new
                                        {
                                            restaurant = r as Restaurant,
                                            kitchenType = kt.KitchenLabel,
                                            imageUrl = img.ImageUrl,
                                            averageRating = rates.Count() > 0 ? (int)rates.Average(x => x.Rate) : 0
                                        })).Distinct().ToListAsync();

            List<RestaurantModel> result = restaurantTemp.Select(x => x.restaurant.ConvertRestaurantToModel(x.kitchenType, x.imageUrl, x.averageRating)).ToList();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Restaurants/5
        //[Authorize(Roles ="Administrator")]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRestaurant(int id, Restaurant restaurant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != restaurant.RestaurantID)
            {
                return BadRequest();
            }

            db.Entry(restaurant).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Restaurants
        //[Authorize(Roles = "Administrator")]
        [ResponseType(typeof(RestaurantModel))]
        public async Task<IHttpActionResult> PostRestaurant(NewRestaurantModel restaurant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Ajoute le restaurant
            db.Restaurants.Add(restaurant.ConvertModelToRestaurant());
            db.SaveChanges();

            var newRestaurant = db.Restaurants.FirstOrDefault(x => x.Name == restaurant.name);

            // Ajoute les images correspondantes
            if (restaurant.images != null && restaurant.images.Count() > 0)
            {
                foreach (var img in restaurant.ConvertModelToImages(newRestaurant.RestaurantID))
                {
                    db.Images.Add(img);
                }
            }

            // Ajoute les kitchenTypes
            if (restaurant.kitchenTypes != null && restaurant.kitchenTypes.Count() > 0)
            {
                foreach (var kt in restaurant.ConvertModelToKitchen(newRestaurant.RestaurantID))
                {
                    db.Kitchens.Add(kt);
                }
            }
            
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = newRestaurant.RestaurantID }, newRestaurant);
        }

        // DELETE: api/Restaurants/5
        //[Authorize(Roles = "Administrator")]
        [ResponseType(typeof(Restaurant))]
        public async Task<IHttpActionResult> DeleteRestaurant(int id)
        {
            Restaurant restaurant = await db.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            db.Restaurants.Remove(restaurant);
            await db.SaveChangesAsync();

            return Ok(restaurant);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RestaurantExists(int id)
        {
            return db.Restaurants.Count(e => e.RestaurantID == id) > 0;
        }
    }
}