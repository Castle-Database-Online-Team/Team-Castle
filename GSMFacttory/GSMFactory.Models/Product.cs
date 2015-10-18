namespace GsmFactory.Models
{
    public class Product
    {
        public int Id { get; set; }

        public ProductType Type { get; set; }

        public string Model { get; set; }

        public virtual Measure Measure { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Os OS { get; set; }

        public virtual Display Display { get; set; }

        public virtual Memory Memory { get; set; }

        public decimal BasePrice { get; set; }

        public Producer Producer { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}