using Microsoft.EntityFrameworkCore;
using YavinOffice.Model;

namespace YavinOffice.Data
{
    public class SiteVisitorDbContext : DbContext
    {
        public SiteVisitorDbContext(DbContextOptions<SiteVisitorDbContext> options) : base(options)
        {
            
        }
        public DbSet<SiteVisitorInfor> SiteVisitors { get; set; }
    }
}
