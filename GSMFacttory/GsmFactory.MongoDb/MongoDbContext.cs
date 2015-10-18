namespace GsmFactory.MongoDb
{
    using System;
    using System.Linq;

    using ExtensionsMethods;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Driver;

    class MongoDbContext
    {
        private const string DatabaseHost = "mongodb://127.0.0.1";
        private const string DatabaseName = "GsmFactory";

        private class Log
        {
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            public string ProduserId { get; set; }

            public string Model { get; set; }

            public string ProductName { get; set; }

            public string MeasureId { get; set; }

            public string DisplayId { get; set; }

            public string PlatformOsId { get; set; }

            public string MemoryId { get; set; }

            public string BasePrice { get; set; }

            public string CurrencyId { get; set; }
        }

        static MongoDatabase GetDatabase(string name, string fromHost)
        {
            var mongoClient = new MongoClient(fromHost);
            var server = mongoClient.GetServer();
            return server.GetDatabase(name);
        }

        private static void Main()
        {
            var db = GetDatabase(DatabaseName, DatabaseHost);
            var gsmFactory = db.GetCollection<Log>("GsmFactory");

            //gsmFactory.Remove();

            gsmFactory.Insert(new Log()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                ProduserId = "31000",
                Model = "IPhone 5S",
                ProductName = "12000",
                MeasureId = "100",
                DisplayId = "10000",
                PlatformOsId = "3000",
                MemoryId = "5200",
                BasePrice = "489.00",
                CurrencyId = "21000"
            });

            var logs = gsmFactory.FindAll()
                .Select(log => log.Model);


            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
