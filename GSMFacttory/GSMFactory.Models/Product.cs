namespace GSMFactory.Models
{
    public class Product
    {
        public int ID { get; set; }

        public ProductType Type { get; set; }

        public string Model { get; set; }

        public int MeasureID { get; set; }

        public Currency Currency { get; set; }

        public OperationalSystem OS { get; set; }

        public int Display { get; set; }

        public int Memory { get; set; }

        public decimal BasePrice { get; set; }

        public Producer Producer { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
