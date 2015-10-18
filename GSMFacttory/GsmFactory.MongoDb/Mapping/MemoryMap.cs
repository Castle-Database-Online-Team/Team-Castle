namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MemoryMap
    {
        [BsonConstructor]
        public MemoryMap(int memoryId, string memoryeName, int measureId)
        {
            this.MemoryId = memoryId;
            this.MemoryName = memoryeName;
            this.MeasureId = measureId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int MeasureId { get; private set; }

        public int MemoryId { get; private set; }

        public string MemoryName { get; private set; }
    }
}
