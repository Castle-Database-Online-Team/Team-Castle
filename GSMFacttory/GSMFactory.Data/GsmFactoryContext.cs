using System.Data.Entity;
using GSMFactory.Models;

namespace GsmFactory.Data
{
    public class GsmFactoryContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Display> Displays{ get; set; }
        public DbSet<Memory> Memories{ get; set; }
    }
}
