namespace GsmFactory.Data.Contracts
{
    using System;
    using GsmFactory.Models;

    public interface IGsmFactoryData : IDisposable
    {
        IGenericRepository<Product> Products { get; }

        IGenericRepository<ProductType> ProductTypes { get; }

        IGenericRepository<Currency> Currencies { get; }

        IGenericRepository<City> Cities { get; }

        IGenericRepository<Display> Displaies { get; }

        IGenericRepository<Measure> Measures { get; }

        IGenericRepository<Memory> Memories { get; }

        IGenericRepository<Os> Os { get; }

        IGenericRepository<Producer> Producers { get; }

        IGenericRepository<Person> Persons { get; }

        IGenericRepository<Vendor> Vendors { get; }

        IGenericRepository<ProduserExpense> Expenses { get; }
        
        IGenericRepository<SalesReport> SalesReports { get; }

        IGenericRepository<SalesReportEntry> SalesReportEntries { get; }

        IGenericRepository<Store> Stores { get; }

        int SaveChanges();
    }
}