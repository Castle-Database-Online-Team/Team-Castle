namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class DisplayMap
    {
        [BsonConstructor]
        public DisplayMap(int displayId, double displayeSize, int measureId)
        {
            this.DisplayId = displayId;
            this.DisplaySize = displayeSize;
            this.MeasureId = measureId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int DisplayId { get; set; }

        public double DisplaySize { get; set; }

        public int MeasureId { get; set; }
    }
}