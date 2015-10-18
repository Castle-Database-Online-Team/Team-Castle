namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class Display
    {
        public Display()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public int Size { get; set; }

        public Measure Measure { get; set; }

        public virtual HashSet<Product> Products { get; set; }
    }
}