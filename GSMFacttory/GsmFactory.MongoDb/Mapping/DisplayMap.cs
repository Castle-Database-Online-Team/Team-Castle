namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class DisplayMap
    {
        [BsonConstructor]
        public DisplayMap(int displayId, string displayeName, int measureId)
        {
            this.DisplayId = displayId;
            this.DisplayName = displayeName;
            this.MeasureId = measureId;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        public int DisplayId { get; set; }

        public string DisplayName { get; set; }

        public int MeasureId { get; set; }
    }
}
