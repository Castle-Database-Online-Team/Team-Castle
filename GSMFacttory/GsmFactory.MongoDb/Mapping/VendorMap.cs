﻿namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class VendorMap
    {
        [BsonConstructor]
        public VendorMap(int vendorId, string vendorName, int cityId, string vendorAddress, int Person)
        {
            this.VendorId = vendorId;
            this.VendorName = vendorName;
            this.CityId = cityId;
            this.VendorAddress = vendorAddress;
            this.Person = Person;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int VendorId { get;  set; }

        public int CityId { get; set; }

        public string VendorName { get;  set; }

        public string VendorAddress { get; set; }

        public int Person { get; set; }
    }
}