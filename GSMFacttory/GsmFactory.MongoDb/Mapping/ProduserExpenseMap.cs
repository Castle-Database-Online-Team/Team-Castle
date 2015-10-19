namespace GsmFactory.MongoDb.Mapping
{
    using System;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class ProduserExpenseMap
    {
        [BsonConstructor]
        public ProduserExpenseMap()
        {
        }

        [BsonConstructor]
        public ProduserExpenseMap(DateTime reportDate, decimal expense, int produserId)
        {
            this.ReportDate = reportDate;
            this.Expense = expense;
            this.ProduserId = produserId;
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public DateTime ReportDate { get; set; }

        public decimal Expense { get; set; }

        public int ProduserId { get; set; }
    }
}