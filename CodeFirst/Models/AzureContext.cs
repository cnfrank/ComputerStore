using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class AzureContext:DbContext
    {
        public DbSet<EFOrder> Order { get; set; }
        public DbSet<EFOrderDetail> EFOrderDetails { get; set; }

        public AzureContext(DbContextOptions<AzureContext> options):base(options) { }
    }
}
