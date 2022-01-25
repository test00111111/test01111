
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.ViewModel;

namespace test.Controllers
{
    public class CommonController : Controller
    {
        shop123Entities db = new shop123Entities();
        // GET: Home
        public ActionResult Common()
        {
            var carousel = db.carousel.ToList();
            var spu = db.spu.OrderByDescending(m => m.spuCreatedTime).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.carousels = carousel;
            vw.spu = spu;
            return View(vw);
        }
        public ActionResult _categorySPU(int catA, int catB)
        {
            List<spu> spu;
            if (catB == 0)
                spu = db.spu.Where(m => m.catalogAId == catA).ToList();
            else
                spu = db.spu.Where(m => m.catalogAId == catA && m.catalogBId==catB).ToList();
            return PartialView("_categorySPU", spu);
        }

        public ActionResult _categoryB(int catA)
        {
            List<catalogB> catalog;           
                catalog = db.catalogB.Where(m => m.catalogAId == catA).ToList();  
            return PartialView("_categoryB", catalog);
        }
        public ActionResult _categoryA()
        {
            List<catalogA> catalog;           
                catalog = db.catalogA.ToList();  
            return PartialView("_categoryA", catalog);
        }

        public ActionResult categoryPage(int catalogAId)
        {
            var cat = db.catalogB.Where(m => m.catalogAId == catalogAId).ToList();
            var spu = db.spu.Where(m => m.catalogAId == catalogAId).ToList();
            CommonViewModel vw = new CommonViewModel();
            vw.category = cat;
            vw.spu= spu;
           
            return View(vw);

        }

    }
}