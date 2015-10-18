namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class ProductMap
    {
        [BsonConstructor]
        public ProductMap(int productId, int productName, string model, int produserId, int measureId, int displayId, int platformOsId, int memoryId, double basePrice, int currencyId)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Model = model;
            this.ProduserId = produserId;
            this.MeasureId = measureId;
            this.DisplayId = displayId;
            this.PlatformOsId = platformOsId;
            this.MemoryId = memoryId;
            this.BasePrice = basePrice;
            this.CurrencyId = currencyId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int ProduserId { get; set; }

        public int ProductName { get; set; }

        public string Model { get; set; }

        public int ProductId { get; set; }

        public int MeasureId { get; set; }

        public int DisplayId { get; set; }

        public int PlatformOsId { get; set; }

        public int MemoryId { get; set; }

        public double BasePrice { get; set; }

        public int CurrencyId { get; set; }
    }
}
