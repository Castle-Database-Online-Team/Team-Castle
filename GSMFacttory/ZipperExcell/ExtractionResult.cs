using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipperExcell
{
    using GsmFactory.Models;

    public class ExtractionResult
    {
        public List<Product> Products { get; set; }

        public List<Currency> Currencies { get; set; }

        public List<Measure> Measures { get; set; }

        public List<Display> Displays { get; set; }

        public List<Memory> Memories { get; set; }

        public List<ProductType> ProductTypes { get; set; }

        public List<Producer> Producers { get; set; }

        public List<Vendor> Vendors { get; set; }

        public List<Person> Persons { get; set; }


    }
}
