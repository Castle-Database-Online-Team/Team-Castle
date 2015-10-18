namespace GsmFactory.MongoDb.Contractd
{
    using MongoDB.Driver;
    using GsmFactory.MongoDb.Mapping;
    interface IMongDbContext
    {
        MongoCollection<ProductNameMap> ProductName { get; }
        MongoCollection<ProduserMap> Produser { get; }
        MongoCollection<MeasureМаp> Measure { get; }
        MongoCollection<DisplayMap> Display { get; }
        MongoCollection<PlatformOsMap> PlatformOs { get; }
        MongoCollection<MemoryMap> Memory { get; }
        MongoCollection<CurrensyMap> Currensy { get; }
        MongoCollection<CityMap> Cities { get; }
    }
}
