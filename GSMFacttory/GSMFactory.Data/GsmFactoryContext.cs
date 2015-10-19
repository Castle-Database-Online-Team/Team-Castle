namespace GsmFactory.Data
{
    using System.Data.Entity;
    using GsmFactory.Models;
    using GsmFactory.Data.Contracts;
    using GsmFactory.Data.Migrations;

    public class GsmFactoryContext : DbContext, IGsmFactoryDbContext
    {
        private const string GsmFactoryDatabaseName = "GsmFactory";
        public GsmFactoryContext()
            : base(GsmFactoryDatabaseName)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GsmFactoryContext, Configuration>());
        }

        public GsmFactoryContext(string connectionString)
            : this()
        {
            this.Database.Connection.ConnectionString = connectionString;
        }

        public IDbSet<City> Citis{ get; set; }


        public IDbSet<Currency> Currencies { get; set; }
        

        public IDbSet<Display> Displaies { get; set; }

        public IDbSet<Measure> Measures { get; set; }

        public IDbSet<Memory> Memories { get; set; }

        public IDbSet<Os> Os { get; set; }

        public IDbSet<Person> Persons { get; set; }

        public IDbSet<Producer> Producers { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<ProductType> ProductTypes { get; set; }

        public IDbSet<SalesReportEntry> SalesReportEntries { get; set; }

        public IDbSet<SalesReport> SalesReports { get; set; }

        public IDbSet<Store> Stores { get; set; }

        public IDbSet<Vendor> Vendors { get; set; }

        public IDbSet<ProduserExpense> Expenses { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}