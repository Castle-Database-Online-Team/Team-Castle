namespace GsmFactory.MongoDb.Mapping
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class PersonMap
    {
        private object vendorAddress;

        [BsonConstructor]
        public PersonMap(int personId, string personName, int phone, string email)
        {
            this.PersonId = personId;
            this.PersonName = personName;
            this.Phone = Phone;
            this.Email = email;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public int PersonId { get; set; }

        public string Phone { get; set; }

        public string PersonName { get; set; }

        public string Email { get; set; }
    }
}