using Microsoft.EntityFrameworkCore;
using Membership.Core.Entities;

namespace Membership.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<Core.Entities.Membership> Memberships { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
    }
}
