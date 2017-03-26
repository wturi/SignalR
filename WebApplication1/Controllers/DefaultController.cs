using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DataBases;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        public JsonResult Get()
        {
            TableEntity tab = new TableEntity();
            var model = tab.GetData();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}