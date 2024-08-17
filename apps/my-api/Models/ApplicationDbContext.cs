// Models/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace FullstackWeb.MyApi.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
    public DbSet<Post> TbPosts { get; set; }
    }
}