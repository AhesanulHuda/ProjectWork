using Project2.Model.Model;
using Project2.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.BLL.BLL
{
   public class ProductBLL
    {
        ProductRepository _productRepository = new ProductRepository();
        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }
        public bool Delete(Product product)
        {
            return _productRepository.Delete(product);
        }
        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public Product GetByID(Product product)
        {
            return _productRepository.GetByID(product);
        }
    }
}
