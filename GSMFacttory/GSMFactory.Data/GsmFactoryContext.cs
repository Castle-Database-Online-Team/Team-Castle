namespace GsmFactory.Data
{
    using System;
    using System.Data.Entity;
    using Models;

    public class GsmFactoryContext : DbContext
    {
        public GsmFactoryContext() : base("GsmFactory")
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProducTypes { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Display> Displays { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<Memory> Memories { get; set; }

        public DbSet<Os> OperatingSystems { get; set; }
    }
}