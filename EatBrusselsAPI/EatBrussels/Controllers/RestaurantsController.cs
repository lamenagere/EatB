using EatBrussels.Entities;
using EatBrussels.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace EatBrussels.Controllers
{
    public class RestaurantsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Restaurants
        public async Task<IHttpActionResult> GetRestaurants()
        {
            var restaurantModels = await(from r in db.Restaurants
                                        join kit in db.Kitchens on r.RestaurantID equals kit.RestaurantID
                                        join kt in db.KitchenTypes on kit.KitchenTypeID equals kt.KitchenTypeID
                                        select new RestaurantModel
                                        {
                                            restaurantID = r.RestaurantID,
                                            name = r.Name,
                                            address = r.Address,
                                            kitchenType = kt.KitchenLabel,
                                            description = "",
                                            openingHours = r.OpeningHour,
                                            closingHours = r.ClosingHour
                                        }).Distinct().ToListAsync();

            return Ok(restaurantModels);
        }

        // GET: api/Restaurants/5
        [ResponseType(typeof(Restaurant))]
        public IHttpActionResult GetRestaurant(int id)
        {
            //Restaurant restaurant = await db.Restaurants.FindAsync(id);

            var restaurantModel = (from r in db.Restaurants.AsParallel()
                                   join kit in db.Kitchens.AsParallel() on r.RestaurantID equals kit.RestaurantID
                                   join kt in db.KitchenTypes.AsParallel() on kit.KitchenTypeID equals kt.KitchenTypeID
                                   where r.RestaurantID == id
                                   select new RestaurantModel
                                   {
                                       restaurantID = r.RestaurantID,
                                       name = r.Name,
                                       address = r.Address,
                                       kitchenType = kt.KitchenLabel,
                                       description = "",
                                       openingHours = r.OpeningHour,
                                       closingHours = r.ClosingHour
                                   }).FirstOrDefault();


            if (restaurantModel == null)
            {
                return NotFound();
            }

            return Ok(restaurantModel);
        }

        // GET: api/Restaurants/
        public async Task<IHttpActionResult> GetRestaurants(string kitchenType)
        {
            var restaurantModels = await (from r in db.Restaurants
                                          join k in db.Kitchens on r.RestaurantID equals k.RestaurantID
                                          join kt in db.KitchenTypes on k.KitchenTypeID equals kt.KitchenTypeID
                                          where kt.KitchenLabel == kitchenType
                                          select new RestaurantModel
                                          {
                                              restaurantID = r.RestaurantID,
                                              name = r.Name,
                                              address = r.Address,
                                              kitchenType = kt.KitchenLabel,
                                              description = "",
                                              openingHours = r.OpeningHour,
                                              closingHours = r.ClosingHour
                                          }).Distinct().ToListAsync();

            if (restaurantModels == null)
            {
                return NotFound();
            }

            return Ok(restaurantModels);
        }

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
        public async Task<IHttpActionResult> PostRestaurant(Restaurant restaurant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Restaurants.Add(restaurant);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = restaurant.RestaurantID }, restaurant);
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