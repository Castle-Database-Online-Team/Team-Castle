namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string PersonName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
