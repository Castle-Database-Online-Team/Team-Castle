﻿namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    using System.Collections.Generic;

    public class Display
    {
        [Key]
        public int Id { get; set; }

        public int Size { get; set; }

        [ForeignKey("Measure")]
        public int MeasureId { get; set; }

        public virtual Measure Measure { get; set; }
    }
}