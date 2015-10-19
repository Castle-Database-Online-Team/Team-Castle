﻿namespace GsmFactory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}