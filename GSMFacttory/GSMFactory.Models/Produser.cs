namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Produser
    {
        [Key]
        public int ProduserId { get; set; }

        [Required]
        public string ProduserName { get; set; }
    }
}
