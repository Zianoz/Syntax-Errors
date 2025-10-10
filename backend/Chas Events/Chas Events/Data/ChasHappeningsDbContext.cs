using Microsoft.EntityFrameworkCore;
using Chas_Events.Models;

namespace Chas_Events.Data
{
    public class ChasHappeningsDbContext : DbContext
    {
        public ChasHappeningsDbContext(DbContextOptions<ChasHappeningsDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //}
    }
}
