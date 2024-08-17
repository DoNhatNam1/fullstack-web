// Models/Post.cs
using System;

namespace FullstackWeb.MyApi.Models
{
    public class Post
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string? CategoryId { get; set; }
        public string? postSlug { get; set; }
        public string? title { get; set; }
        public string? shortDesc { get; set; }
        public string? descHTML { get; set; }
        public string? keywords { get; set; }
        public string? siteName { get; set; }
        public int views { get; set; } = 0;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}
