namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MemoryMap
    {
        [BsonConstructor]
        public MemoryMap(int memoryId, int memoryeSize, int measureId)
        {
            this.MemoryId = memoryId;
            this.MemorySize = memoryeSize;
            this.MeasureId = measureId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int MeasureId { get; set; }

        public int MemoryId { get; set; }

        public int MemorySize { get; set; }
    }
}