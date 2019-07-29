using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Model.Model
{
     public class Product
    {
        public List<Product> products;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int ReorderLavel { get; set; }
        public string Description { get; set; }
        public int Catagory_ID { get; set; }
        public List<Catagory> Catagories { get; set; }

    }
}
