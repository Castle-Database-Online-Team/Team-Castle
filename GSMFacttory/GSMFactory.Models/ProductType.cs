namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class ProductType
    {
        public ProductType()
        {
            this.Products = new HashSet<Product>();
        }

        public virtual HashSet<Product> Products { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}