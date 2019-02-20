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

namespace EatBrussels.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class RestaurantsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Restaurants    retourne tout les resto par rating décroissant
        public async Task<IHttpActionResult> GetRestaurants()
        {
            var restaurantModels = await (from r in db.Restaurants
                                          join kit in db.Kitchens on r.RestaurantID equals kit.RestaurantID
                                          join kt in db.KitchenTypes on kit.KitchenTypeID equals kt.KitchenTypeID
                                          join img in db.Images on r.RestaurantID equals img.RestaurantID
                                          join rt in db.Ratings on r.RestaurantID equals rt.RestaurantID into rates
                                          
                                          
                                          select new RestaurantModel
                                          {
                                              restaurantID = r.RestaurantID,
                                              name = r.Name,
                                              address = r.Address,
                                              kitchenType = kt.KitchenLabel,
                                              description = "",
                                              openingHour = r.OpeningHour,
                                              closingHour = r.ClosingHour,
                                              imageUrl = img.ImageUrl,
                                              averageRating = rates.Count() > 0 ? (int)rates.Average(x => x.Rate) : 0
                                          }).Distinct().OrderByDescending(x => x.averageRating).ToListAsync();

            if (restaurantModels == null)
            {
                return NotFound();
            }

            return Ok(restaurantModels);
        }

        // GET: api/Restaurants/5
        [ResponseType(typeof(Restaurant))]
        public IHttpActionResult GetRestaurant(int id)
        {
            var restaurantModel = (from r in db.Restaurants.AsParallel()
                                   join kit in db.Kitchens.AsParallel() on r.RestaurantID equals kit.RestaurantID
                                   join kt in db.KitchenTypes.AsParallel() on kit.KitchenTypeID equals kt.KitchenTypeID
                                   join img in db.Images.AsParallel() on r.RestaurantID equals img.RestaurantID
                                   where r.RestaurantID == id
                                   select new RestaurantModel
                                   {
                                       restaurantID = r.RestaurantID,
                                       name = r.Name,
                                       address = r.Address,
                                       kitchenType = kt.KitchenLabel,
                                       description = "",
                                       openingHour = r.OpeningHour,
                                       closingHour = r.ClosingHour,
                                       imageUrl = img.ImageUrl
                                   }).FirstOrDefault();


            if (restaurantModel == null)
            {
                return NotFound();
            }

            return Ok(restaurantModel);
        }

        // GET: api/Restaurants/type de cuisine
        public async Task<IHttpActionResult> GetRestaurants(string kitchenType)
        {
            var restaurantModels = await (from r in db.Restaurants
                                          join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
                                          join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
                                          join img in db.Images on r.RestaurantID equals img.RestaurantID
                                          where kt.KitchenLabel == kitchenType
                                          select new RestaurantModel
                                          {
                                              restaurantID = r.RestaurantID,
                                              name = r.Name,
                                              address = r.Address,
                                              kitchenType = kt.KitchenLabel,
                                              description = "",
                                              openingHour = r.OpeningHour,
                                              closingHour = r.ClosingHour,
                                              imageUrl = img.ImageUrl
                                          }).Distinct().ToListAsync();

            if (restaurantModels == null)
            {
                return NotFound();
            }

            return Ok(restaurantModels);
        }

        // GET: api/Restaurants/code postal
        public async Task<IHttpActionResult> GetRestaurantsByZipCode(string zipCode)
        {
            var restaurantModels = await (from r in db.Restaurants
                                          join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
                                          join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
                                          join i in db.Images on r.RestaurantID equals i.RestaurantID
                                          where r.ZipCode == zipCode
                                          
                                          select new RestaurantModel
                                          {
                                              restaurantID = r.RestaurantID,
                                              name = r.Name,
                                              address = r.Address,
                                              kitchenType = kt.KitchenLabel,
                                              description = "",
                                              openingHour = r.OpeningHour,
                                              closingHour = r.ClosingHour,
                                              imageUrl = i.ImageUrl
                                          }).Distinct().ToListAsync();

            if (restaurantModels == null)
            {
                return NotFound();
            }

            return Ok(restaurantModels);
        }

        //GET: api/Restaurants/rating
        //public async Task<IHttpActionResult> GetRestaurantsByRating(int rating)
        //{
        //    var restaurantModels = await(from r in db.Restaurants
        //                                 join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
        //                                 join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
        //                                 join i in db.Images on r.RestaurantID equals i.RestaurantID
        //                                 join rt in db.Ratings on r.RestaurantID equals rt.RestaurantID
        //                                 where rt.RatingID == rating

        //                                 select new RestaurantModel
        //                                 {
        //                                     restaurantID = r.RestaurantID,
        //                                     name = r.Name,
        //                                     address = r.Address,
        //                                     kitchenType = kt.KitchenLabel,
        //                                     description = "",
        //                                     openingHour = r.OpeningHour,
        //                                     closingHour = r.ClosingHour,
        //                                     imageUrl = i.ImageUrl
        //                                 }Distinct().ToListAsync();
        //    if (restaurantModels == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(restaurantModels);
        //        )
        //}

        // PUT: api/Restaurants/5
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
        [ResponseType(typeof(Restaurant))]
        public async Task<IHttpActionResult> PostRestaurant(RestaurantModel restaurant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newRestaurant = db.Restaurants.Add(restaurant.ConvertModelToRestaurant());
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = newRestaurant.RestaurantID }, newRestaurant);
        }

        // DELETE: api/Restaurants/5
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