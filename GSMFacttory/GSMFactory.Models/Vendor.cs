namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class Vendor
    {
        public Vendor()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual HashSet<Product> Products { get; set; }
    }
}