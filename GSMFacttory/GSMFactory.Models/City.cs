namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
