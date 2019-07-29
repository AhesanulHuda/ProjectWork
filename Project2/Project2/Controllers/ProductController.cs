using Project2.BLL.BLL;
using Project2.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        ProductBLL _productBll = new ProductBLL();
        private Product _product = new Product();

        // GET: Catagory
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {

            if (ModelState.IsValid)
            {
                if (_productBll.Add(product))
                {
                    ViewBag.SuccesMsg = "Saved";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            _product.ID = Convert.ToInt32(Id);
            var product = _productBll.GetByID(_product);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {

            if (ModelState.IsValid)
            {
                if (_productBll.Update(product))
                {
                    ViewBag.SuccesMsg = "Updated";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";

            return View(product);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            _product.ID = Convert.ToInt32(Id);
            var product = _productBll.GetByID(_product);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {

            if (ModelState.IsValid)
            {
                if (_productBll.Delete(product))
                {
                    ViewBag.SuccesMsg = "Deleted Data";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";

            return View(product);
        }
        [HttpGet]
        public ActionResult Show()
        {
            _product.products = _productBll.GetAll();
            return View(_product);
        }

        [HttpPost]
        public ActionResult Show(Product product)
        {
            var products = _productBll.GetAll();
            if (product.Name != null)
            {
                products = products.Where(c => c.Name.ToLower().Contains(product.Name.ToLower())).ToList();
            }
            if (product.Code != null)
            {
                products = products.Where(c => c.Code.ToLower().Contains(product.Code.ToLower())).ToList();
            }
            if (product.ReorderLavel > 0)
            {
                products = products.Where(c => c.ReorderLavel==product.ReorderLavel).ToList();
            }
            if (product.Description != null)
            {
                products = products.Where(c => c.Description.ToLower().Contains(product.Description.ToLower())).ToList();
            }
            if (product.Catagory_ID != null)
            {
                products = products.Where(c => c.Catagory_ID==product.Catagory_ID).ToList();
            }


            product.products = products;
            return View(product);
        }

    }
}