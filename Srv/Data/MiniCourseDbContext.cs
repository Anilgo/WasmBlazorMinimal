using Microsoft.EntityFrameworkCore;
using Middle.Models;

namespace Srv.Data;

public sealed class MiniCourseDbContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();

	public MiniCourseDbContext(DbContextOptions<MiniCourseDbContext> options) : base(options: options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var postToSeed = new Post[6];
        for (int i =1; i <= 6; i++)
        {
            postToSeed[i - 1] = new Post()
            {
                PostId = i,
                Title = $"{i}",
                Content = $"This is {i}th post and {i}th example"
            };
        } 
        builder.Entity<Post>().HasData(postToSeed);
    }

}
