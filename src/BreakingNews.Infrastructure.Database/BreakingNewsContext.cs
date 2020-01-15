using Microsoft.EntityFrameworkCore;

namespace BreakingNews.Infrastructure.Database
{
    public class BreakingNewsContext : DbContext
    {
        public BreakingNewsContext()
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
