// Controllers/PostsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullstackWeb.MyApi.Models;

namespace FullstackWeb.MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

    // GET: api/posts
    [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await _context.TbPosts.ToListAsync();
        }

        // GET: api/posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(string id)
        {
            var post = await _context.TbPosts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        // POST: api/posts
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            _context.TbPosts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPost), new { id = post.id }, post);
        }

        // PUT: api/posts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(string id, Post post)
        {
            if (id != post.id)
            {
                return BadRequest();
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(string id)
        {
            var post = await _context.TbPosts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.TbPosts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostExists(string id)
        {
            return _context.TbPosts.Any(e => e.id == id);
        }
    }
}
