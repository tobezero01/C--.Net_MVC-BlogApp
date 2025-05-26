using Blog.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
	public class ApplicationBbContext : DbContext
	{
		public ApplicationBbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<Tag> Tags { get; set; }

	}
}
