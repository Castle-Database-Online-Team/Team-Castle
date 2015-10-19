namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class ProductNameMap
    {
        private string thisProductNameName;

        [BsonConstructor]
        public ProductNameMap(int productNameId, string productNameName)
        {
            this.ProductNameId = productNameId;
            this.ProductNameName = productNameName;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int ProductNameId { get; set; }

        public string ProductNameName { get; set; }
    }
}