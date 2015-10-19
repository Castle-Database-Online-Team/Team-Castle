namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class ProduserMap
    {
        [BsonConstructor]
        public ProduserMap(int produserId, string produserName)
        {
            this.ProduserId = produserId;
            this.ProduserName = produserName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int ProduserId { get; set; }

        public string ProduserName { get; set; }
    }
}