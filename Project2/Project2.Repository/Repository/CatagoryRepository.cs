
using Project2.DBContext.ProjectDBContext;
using Project2.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2.Repository.Repository
{
   public class CatagoryRepository
    {
        Project2DBContext db = new Project2DBContext();
        public bool Add(Catagory catagory)
        {
            int isExecuted = 0;

            db.Catagories.Add(catagory);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Catagory catagory)
        {
            int isExecuted = 0;
            Catagory aCatagory = db.Catagories.FirstOrDefault(c => c.ID == catagory.ID);

            db.Catagories.Remove(aCatagory);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Catagory catagory)
        {
            int isExecuted = 0;
           
            db.Entry(catagory).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
        public List<Catagory> GetAll()
        {
            return db.Catagories.ToList();
        }
        public Catagory GetByID(Catagory catagory)
        {
            Catagory aStudent = db.Catagories.FirstOrDefault(c => c.ID == catagory.ID);
            return aStudent;
        }
    }
}
