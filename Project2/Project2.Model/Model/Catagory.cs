using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Model.Model
{
   public class Catagory
    {
        public List<Catagory> catagories;

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
