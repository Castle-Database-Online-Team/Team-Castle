namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class PlatformOsMap
    {
        public PlatformOsMap(int platformOsId, string platformOsName)
        {
            this.PaltrformOsId = platformOsId;
            this.PlatrformOsName = platformOsName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int PaltrformOsId { get; set; }

        public string PlatrformOsName { get; set; }
    }
}