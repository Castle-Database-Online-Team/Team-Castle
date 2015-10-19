namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }

        [Required]
        public string Model { get; set; }

        [ForeignKey("Measure")]
        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }

        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }

        [ForeignKey("OS")]
        public int OSId { get; set; }

        public virtual Os OS { get; set; }

        [ForeignKey("Display")]
        public int DisplayId { get; set; }

        public virtual Display Display { get; set; }

        [ForeignKey("Memory")]
        public int MemoryId { get; set; }

        public virtual Memory Memory { get; set; }

        public decimal BasePrice { get; set; }

        [ForeignKey("Producer")]
        public int ProducerId { get; set; }

        public virtual Producer Producer { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}