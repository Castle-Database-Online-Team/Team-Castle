namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class Measure
    {
        public Measure()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual HashSet<Product> Products { get; set; }
    }
}