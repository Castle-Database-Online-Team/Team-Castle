namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Memory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Size { get; set; }

        [ForeignKey("Measure")]
        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }
    }
}