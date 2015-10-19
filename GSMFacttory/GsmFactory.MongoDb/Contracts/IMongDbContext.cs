namespace GsmFactory.MongoDb.Contracts
{
    using Mapping;
    using MongoDB.Driver;

    public interface IMongDbContext
    {
        MongoCollection<ProductNameMap> ProductName { get; }

        MongoCollection<ProduserMap> Produser { get; }

        MongoCollection<ProductMap> Products { get; }

        MongoCollection<ProduserExpenseMap> ProduserExpense { get; }

        MongoCollection<MeasureМаp> Measure { get; }

        MongoCollection<DisplayMap> Display { get; }

        MongoCollection<PlatformOsMap> PlatformOs { get; }

        MongoCollection<MemoryMap> Memory { get; }

        MongoCollection<CurrensyMap> Currensy { get; }

        MongoCollection<CityMap> Cities { get; }
        MongoCollection<PersonMap> Persons { get; }
        MongoCollection<VendorMap> Vendor { get; }

    }
}