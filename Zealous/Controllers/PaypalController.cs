using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class PaypalController : Controller
    {
        
        public ActionResult Index()
        {
            if (Session["cart"]==null)
            {
                return RedirectToAction("Index","Home");
            }
            var ls = Session["cart"] as List<Product>;
            return View(ls);
        }

        public ActionResult GetDataPaypal()
        {
            var getData = new GetDataPaypal();
            var order = getData.InformationOrder(getData.GetPayPalResponse(Request.QueryString["tx"]));
            ViewBag.tx = Request.QueryString["tx"];
            return View();
        }

    }
}