namespace GsmFactory.Models
{
    using System.Collections.Generic;

    public class Memory
    {
        public Memory()
        {
            this.Products = new HashSet<Product>();
        }

        public virtual HashSet<Product> Products { get; set; }

        public int Id { get; set; }

        public int Size { get; set; }

        public Measure Measure { get; set; }
    }
}