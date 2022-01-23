
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.ViewModel;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        shop123Entities db = new shop123Entities();
        // GET: Home
        public ActionResult Index()
        {
            IndexViewModel all = new IndexViewModel();
            return View(all);
        }

        public ActionResult WOMAN()
        {
            WOMANViewModel woman=new WOMANViewModel();            
            return View(woman);
        }
    }
}