namespace RobotsFactory.Data.Contracts
{
    using System;
    using System.Linq;
    using GsmFactory.Models;

    public interface IGsmFactoryData : IDisposable
    {
        IGenericRepository<Product> Products { get; }

        IGenericRepository<ProductType> ProductTypes { get; }

        IGenericRepository<Currency> Currencies { get; }

        IGenericRepository<Display> Displaies { get; }

        IGenericRepository<Measure> Measures { get; }

        IGenericRepository<Memory> Memories { get; }

        IGenericRepository<Os> Os { get; }

        IGenericRepository<Producer> Producers { get; }

        IGenericRepository<Vendor> Vendors { get; }

        int SaveChanges();
    }
}