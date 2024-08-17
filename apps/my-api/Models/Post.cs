// Models/Post.cs
using System;

namespace FullstackWeb.MyApi.Models
{
    public class Post
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public required string CategoryId { get; set; }
        public required string postSlug { get; set; }
        public required string title { get; set; }
        public required string shortDesc { get; set; }
        public required string descHTML { get; set; }
        public required string keywords { get; set; }
        public required string siteName { get; set; }
        public int views { get; set; } = 0;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}
