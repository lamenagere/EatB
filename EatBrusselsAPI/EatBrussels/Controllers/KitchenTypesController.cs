using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EatBrussels.Entities;
using EatBrussels.Models;

namespace EatBrussels.Controllers
{
    public class KitchenTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/KitchenTypes
        public IQueryable<KitchenTypeModel> GetKitchenTypes()
        {
            var kitchenTypes = db.KitchenTypes.Select( x => new KitchenTypeModel() { id = x.KitchenTypeID, label = x.KitchenLabel });

            return kitchenTypes;
        }

        // GET: api/KitchenTypes/5
        [ResponseType(typeof(KitchenType))]
        public IHttpActionResult GetKitchenType(int id)
        {
            KitchenType kitchenType = db.KitchenTypes.Find(id);
            if (kitchenType == null)
            {
                return NotFound();
            }

            return Ok(kitchenType);
        }

        // PUT: api/KitchenTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKitchenType(int id, KitchenType kitchenType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kitchenType.KitchenTypeID)
            {
                return BadRequest();
            }

            db.Entry(kitchenType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KitchenTypeExists(id))
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

        // POST: api/KitchenTypes
        [ResponseType(typeof(KitchenType))]
        public IHttpActionResult PostKitchenType(KitchenType kitchenType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KitchenTypes.Add(kitchenType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kitchenType.KitchenTypeID }, kitchenType);
        }

        // DELETE: api/KitchenTypes/5
        [ResponseType(typeof(KitchenType))]
        public IHttpActionResult DeleteKitchenType(int id)
        {
            KitchenType kitchenType = db.KitchenTypes.Find(id);
            if (kitchenType == null)
            {
                return NotFound();
            }

            db.KitchenTypes.Remove(kitchenType);
            db.SaveChanges();

            return Ok(kitchenType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KitchenTypeExists(int id)
        {
            return db.KitchenTypes.Count(e => e.KitchenTypeID == id) > 0;
        }
    }
}