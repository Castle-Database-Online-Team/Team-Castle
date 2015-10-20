namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }  
          
        public virtual string City { get; set; }
        
        public string VendorAddress { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public virtual string Person { get; set; }
    }
}