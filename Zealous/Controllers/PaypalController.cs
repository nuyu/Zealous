using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class PaypalController : ZealousController
    {

        public ActionResult Index()
        {
            if (Session["cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //pass data to be used in view
            var ls = Session["cart"] as List<Product>;
            return View(ls);


        }
       



        /// <summary>
        /// /this function 
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDataPaypal()
        {
            var getData = new GetDataPaypal();
            var order = getData.InformationOrder(getData.GetPayPalResponse(Request.QueryString["tx"]));
            ViewBag.tx = Request.QueryString["tx"];


            var payment = new Payment();
            payment.Amount = order.GrossTotal;
           
            payment.Date = DateTime.Now;
            payment.EventId = 1;
            db.Payments.Add(payment);
            db.SaveChanges();
            Session["cart"] =null;
            return View(order);
        }
       

    }
}