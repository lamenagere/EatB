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
using EatBrussels.Mapper;
using EatBrussels.Models;

namespace EatBrussels.Controllers
{
    public class CommentsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Comments
        public IQueryable<Comment> GetComments()
        {
            return db.Comments;
        }

        // GET: api/Comments/5
        [ResponseType(typeof(Comment))]
        public IHttpActionResult GetComment(int id)
        {
            CommentModel commentModel = db.Comments.Find(id).ConvertToCommentModel();
            if (commentModel == null)
            {
                return NotFound();
            }

            return Ok(commentModel);
        }

        // PUT: api/Comments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComment(int id, CommentModel comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comment.commentID)
            {
                return BadRequest();
            }

            db.Entry(comment.ConvertToComment()).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
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

        // POST: api/Comments
        [ResponseType(typeof(Comment))]
        public IHttpActionResult PostComment(CommentModel comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Comment newComment = db.Comments.Add(comment.ConvertToComment());
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = newComment.CommentID }, newComment);
        }

        // DELETE: api/Comments/5
        [ResponseType(typeof(Comment))]
        public IHttpActionResult DeleteComment(int id)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return NotFound();
            }

            db.Comments.Remove(comment);
            db.SaveChanges();

            return Ok(comment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CommentExists(int id)
        {
            return db.Comments.Count(e => e.CommentID == id) > 0;
        }
    }
}