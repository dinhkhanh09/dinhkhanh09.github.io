using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWeb.Model;

namespace LTWeb.Controllers
{
    public class TempController : Controller
    {
        Model1 _db = new Model1();
        // GET: Temp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in _db.menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        [ChildActionOnly]
        public PartialViewResult getcategory(long id)
        {
            ViewBag.meta = "san-pham";
            var v = from t in _db.categories
                    where t.menuid == id && t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}