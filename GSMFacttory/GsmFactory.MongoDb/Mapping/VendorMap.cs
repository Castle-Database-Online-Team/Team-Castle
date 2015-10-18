namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class VendorMap
    {
        [BsonConstructor]
        public VendorMap(int vendorId, string vendorName, int cityId, string vendorAddress)
        {
            this.VendorMapId = vendorId;
            this.VendorMapName = vendorName;
            this.CityId = cityId;
            this.VendorAddress = vendorAddress;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public string VendorAddress { get; private set; }

        public int VendorMapId { get; private set; }

        public int CityId { get; private set; }

        public string VendorMapName { get; private set; }
    }
}
