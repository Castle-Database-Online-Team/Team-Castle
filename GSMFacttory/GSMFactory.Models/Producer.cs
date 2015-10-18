using System.Collections.Generic;

namespace GSMFactory.Models
{
    public class Producer
    {
        public Producer()
        {
            this.Products = new HashSet<Product>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual HashSet<Product> Products { get; set; }
    }
}
