using Project2.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2.DBContext.ProjectDBContext
{
    public class Project2DBContext:DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
