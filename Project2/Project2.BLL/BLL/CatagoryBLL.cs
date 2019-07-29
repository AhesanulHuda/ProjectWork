using Project2.Model.Model;
using Project2.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.BLL.BLL
{
    public class CatagoryBLL
    {
        CatagoryRepository _catagoryRepository = new CatagoryRepository();
        public bool Add(Catagory catagory)
        {
            return _catagoryRepository.Add(catagory);
        }
        public bool Delete(Catagory catagory)
        {
            return _catagoryRepository.Delete(catagory);
        }
        public bool Update(Catagory catagory)
        {
            return _catagoryRepository.Update(catagory);
        }
        public List<Catagory> GetAll()
        {
            return _catagoryRepository.GetAll();
        }
        public Catagory GetByID(Catagory catagory)
        {
            return _catagoryRepository.GetByID(catagory);
        }
    }
}
