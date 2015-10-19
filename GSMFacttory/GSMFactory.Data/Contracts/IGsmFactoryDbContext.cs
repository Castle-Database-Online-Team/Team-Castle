namespace GsmFactory.Data.Contracts
{
    using System.Data.Entity;
    using GsmFactory.Models;

    public interface IGsmFactoryDbContext : IDbContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<ProductType> ProductTypes { get; set; }

        IDbSet<Producer> Producers { get; set; }

        IDbSet<Currency> Currencies { get; set; }

        IDbSet<Display> Displaies { get; set; }

        IDbSet<Measure> Measures { get; set; }

        IDbSet<Memory> Memories { get; set; }

        IDbSet<Os> Os { get; set; }

        IDbSet<Vendor> Vendors { get; set; }

        IDbSet<City> Citis { get; set; }

        IDbSet<Person> Persons { get; set; }

        IDbSet<ProduserExpense> Expenses { get; set; }

        IDbSet<SalesReport> SalesReports { get; set; }

        IDbSet<SalesReportEntry> SalesReportEntries { get; set; }

        IDbSet<Store> Stores { get; set; }
    }
}