namespace GsmFactory.Data.Contracts
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GsmFactory.Models;

    public interface IRobotsFactoryDbContext : IDbContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<ProductType> ProductTypes { get; set; }

        IDbSet<Producer> Producers { get; set; }

        IDbSet<Currency> Currencies { get; set; }

        IDbSet<Display> Displaies { get; set; }

        IDbSet<Measure> Measures { get; set; }

        IDbSet<Memory> Memories { get; set; }

        IDbSet<Os> Os { get; set; }

        IDbSet<Store> Stores { get; set; }
    }
}