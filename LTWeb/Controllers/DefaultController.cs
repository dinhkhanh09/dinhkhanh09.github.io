using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWeb.Model;

namespace LTWeb.Controllers
{
    public class DefaultController : Controller
    {
        Model1 _db = new Model1();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        
}