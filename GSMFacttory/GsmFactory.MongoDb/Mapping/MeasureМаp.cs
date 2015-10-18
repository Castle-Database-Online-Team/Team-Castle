namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MeasureМаp
    {
        [BsonConstructor]
        public MeasureМаp(int measureId, string masureName)
        {
            this.MeasureId = measureId;
            this.MeasureName = masureName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int MeasureId { get; set; }

        public string MeasureName { get; set; }
    }
}