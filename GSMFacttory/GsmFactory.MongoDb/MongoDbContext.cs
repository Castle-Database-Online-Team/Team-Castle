namespace GsmFactory.MongoDb
{
    using System;

    using GsmFactory.MongoDb.Contracts;
    using GsmFactory.MongoDb.Mapping;
    using MongoDB.Driver;

    public class MongoDbContext : IMongDbContext
    {
        private readonly string connectionString;
        private readonly string databaseName;

        public MongoDbContext()
            : this(ConnectionStrings.Default.MongoDbCloudDatabase, ConnectionStrings.Default.MongoDbDefaultDatabase)
        {
        }

        public MongoDbContext(string connectionString, string databaseName)
        {
            this.connectionString = connectionString;
            this.databaseName = databaseName;
        }

        public MongoCollection<VendorMap> Vendor
        {
            get { return this.GetCollection<VendorMap>("Vendor"); }
        }

        public MongoCollection<PersonMap> Person
        {
            get { return this.GetCollection<PersonMap>("Person"); }
        }

        public MongoCollection<ProductNameMap> ProductName
        {
            get { return this.GetCollection<ProductNameMap>("ProductName"); }
        }

        public MongoCollection<ProduserMap> Produser
        {
            get { return this.GetCollection<ProduserMap>("Produser"); }
        }

        public MongoCollection<MeasureМаp> Measure
        {
            get { return this.GetCollection<MeasureМаp>("Measure"); }
        }

        public MongoCollection<DisplayMap> Display
        {
            get { return this.GetCollection<DisplayMap>("Display"); }
        }

        public MongoCollection<PlatformOsMap> PlatformOs
        {
            get { return this.GetCollection<PlatformOsMap>("PlatformOs"); }
        }

        public MongoCollection<MemoryMap> Memory
        {
            get { return this.GetCollection<MemoryMap>("Memory"); }
        }

        public MongoCollection<CurrensyMap> Currensy
        {
            get { return this.GetCollection<CurrensyMap>("Currensy"); }
        }

        public MongoCollection<CityMap> Cities
        {
            get { return this.GetCollection<CityMap>("Cities"); }
        }            

        public MongoCollection<ProduserExpenseMap> ProduserExpense
        {
            get
            {
                return this.GetCollection<ProduserExpenseMap>("ProduserExpenses");
            }
        }

        public MongoCollection<ProductMap> Products
        {
            get
            {
                return this.GetCollection<ProductMap>("Products");
            }
        }

        public MongoCollection<PersonMap> Persons
        {
            get
            {
                return this.GetCollection<PersonMap>("Persons");
            }
        }

        private MongoCollection<T> GetCollection<T>(string collectionName)
        {
            var database = this.GetDatabase();
            var collection = database.GetCollection<T>(collectionName);
            return collection;
        }

        private MongoDatabase GetDatabase()
        {
            var mongoClient = new MongoClient(this.connectionString);
            var server = mongoClient.GetServer();
            var db = server.GetDatabase(this.databaseName);
            return db;
        }
    }
}