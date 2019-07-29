using Project2.BLL.BLL;
using Project2.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class CatagoryController : Controller
    {
        CatagoryBLL _catagoryBLL = new CatagoryBLL();
        private Catagory _catagory = new Catagory();

        // GET: Catagory
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Catagory catagory)
        {

            
            if (ModelState.IsValid)
            {
                if (_catagoryBLL.Add(catagory))
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
            _catagory.ID = Convert.ToInt32(Id);
            var catagory = _catagoryBLL.GetByID(_catagory);
            return View(catagory);
        }

        [HttpPost]
        public ActionResult Edit(Catagory catagory)
        {

            if (ModelState.IsValid)
            {
                if (_catagoryBLL.Update(catagory))
                {
                    ViewBag.SuccesMsg = "Updated";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";

            return View(catagory);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            _catagory.ID = Convert.ToInt32(Id);
            var catagory = _catagoryBLL.GetByID(_catagory);
            return View(catagory);
        }

        [HttpPost]
        public ActionResult Delete(Catagory catagory)
        {

            if (ModelState.IsValid)
            {
                if (_catagoryBLL.Delete(catagory))
                {
                    ViewBag.SuccesMsg = "Deleted Data";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";

            return View(catagory);
        }
        [HttpGet]
        public ActionResult Show()
        {
            _catagory.catagories = _catagoryBLL.GetAll();
            return View(_catagory);
        }

        [HttpPost]
        public ActionResult Show(Catagory catagory)
        {
            var catagories = _catagoryBLL.GetAll();
            if (catagory.Name != null)
            {
                catagories = catagories.Where(c => c.Name.ToLower().Contains(catagory.Name.ToLower())).ToList();
            }
            if (catagory.Code != null)
            {
                catagories = catagories.Where(c => c.Code.ToLower().Contains(catagory.Code.ToLower())).ToList();
            }
            

            catagory.catagories = catagories;
            return View(catagory);
        }

    
    }
}