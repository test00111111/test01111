
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
            var carousel=db.carousel.ToList();
            var spu=db.spu.OrderByDescending(m=>m.spuCreatedTime).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.carousels = carousel;
            vw.spu = spu;
            return View(vw);         
        }

        public ActionResult WOMAN()
        {
            var category = db.catalogB.ToList();
            var spu = db.spu.Where(m=>m.catalogAId==1).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.category = category;
            vw.spu = spu;
            return View(vw);
        }
         public ActionResult MAN()
        {
            var category = db.catalogB.ToList();
            var spu = db.spu.Where(m => m.catalogAId == 2).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.category = category;
            vw.spu = spu;
            return View(vw);
        }
         public ActionResult KIDS()
        {
            var category = db.catalogB.ToList();
            var spu = db.spu.Where(m => m.catalogAId == 3).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.category = category;
            vw.spu = spu;
            return View(vw);
        }
         public ActionResult BABY()
        {
            var category = db.catalogB.ToList();
            var spu = db.spu.Where(m => m.catalogAId == 4).ToList();

            CommonViewModel vw = new CommonViewModel();
            vw.category = category;
            vw.spu = spu;
            return View(vw);
        }

        
    }
}