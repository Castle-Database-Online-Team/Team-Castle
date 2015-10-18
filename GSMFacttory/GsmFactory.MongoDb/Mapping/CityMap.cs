namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class CityMap
    {
        [BsonConstructor]
        public CityMap(int cityId, string cityName)
        {
            this.CityId = cityId;
            this.CityName = cityName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int CityId { get; private set; }

        public string CityName { get; private set; }
    }
}