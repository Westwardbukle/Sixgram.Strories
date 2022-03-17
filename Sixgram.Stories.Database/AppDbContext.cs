using Microsoft.EntityFrameworkCore;
using Sixgram.Stories.Database.Models;
using Sixgram.Stories.Database.TablesConfiguration;

namespace Sixgram.Stories.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<StoryModel> StoriesModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoryModelConfiguration());
        }
    }
}