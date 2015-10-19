namespace GsmFactory.Data.Contracts
{
    using System;
    using GsmFactory.Models;
    public interface IGsmFactoryData : IDisposable
    {
        IGenericRepository<Product> Products { get; }

        IGenericRepository<ProductType> ProductTypes { get; }

        IGenericRepository<Producer> Producers { get; }

        IGenericRepository<Person> Person { get; }

        IGenericRepository<City> Cities { get; }

        IGenericRepository<Display> Display { get; }

        IGenericRepository<Measure> Measure { get; }

        IGenericRepository<Memory> Memory { get; }

        IGenericRepository<Vendor> Vendor { get; }

        IGenericRepository<ProduserExpense> Expenses { get; }

        IGenericRepository<SalesReport> SalesReports { get; }

        IGenericRepository<SalesReportEntry> SalesReportEntries { get; }

        IGenericRepository<Store> Stores { get; }


        int SaveChanges();
    }
}