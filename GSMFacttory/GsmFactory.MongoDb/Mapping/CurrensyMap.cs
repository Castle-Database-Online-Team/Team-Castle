namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class CurrensyMap
    {
        [BsonConstructor]
        public CurrensyMap(int currensyId, string currensyName)
        {
            this.CurrensyId = currensyId;
            this.CurrensyName = currensyName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int CurrensyId { get; set; }

        public string CurrensyName { get; set; }
    }
}