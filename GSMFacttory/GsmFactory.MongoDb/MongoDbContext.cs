namespace GsmFactory.MongoDb
{
    using System;
    using MongoDB.Driver;
    using GsmFactory.MongoDb.Contractd;
    using GsmFactory.MongoDb.Mapping;

    public class MongoDbContext : IMongDbContext
    {
        private const string DatabaseHost = "mongodb://127.0.0.1";
        private const string DatabaseName = "GsmFactory";

        private readonly string conectionHost ;
        private readonly string databaseName;

        public MongoDbContext(string DatabaseHost, string DatabaseName)
        {
            this.conectionHost = DatabaseHost;
            this.databaseName = DatabaseName;
        }

        public MongoCollection<ProductNameMap> ProductName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<ProduserMap> Produser
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<MeasureМаp> Measure
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<DisplayMap> Display
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<PlatformOsMap> PlatformOs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<MemoryMap> Memory
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<CurrensyMap> Currensy
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MongoCollection<CityMap> Cities
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            var database = this.GetDatabase();
            var collection = database.GetCollection<T>(collectionName);
            return (MongoDB.Driver.IMongoCollection<T>)collection;
        }

        private MongoDatabase GetDatabase()
        {
            var mongoClient = new MongoClient(this.conectionHost);
            var server = mongoClient.GetServer();
            var db = server.GetDatabase(this.databaseName);
            return db;
        }
    }
}
