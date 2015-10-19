﻿namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class Currency
    {
        public Currency()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual HashSet<Product> Products { get; set; }
    }
}