using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class PaymentController : ZealousController
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
        public ActionResult OrderNow(int? id)
        {
            var p = db.Products.FirstOrDefault(t => t.Id == id);
            List<Product> IsCart;
            if (p == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (Session["strCart"] == null)
            {
               IsCart = new List<Product>
                {
                   p
            };
                Session["strCart"] = IsCart;

            }
            else
            {
                 IsCart = (List<Product>)Session["strCart"];

                IsCart.Add(p);
                Session["strCart"] = IsCart;
            }


            return View("index", IsCart);


        }
       



        public ActionResult Delete(int? id)
        {
            //db.Products.FirstOrDefault(t=>t.Id==id);
            List<Product> IsCart = (List<Product>)Session["strCart"];
            var p = IsCart.FirstOrDefault(t => t.Id == id);
            if (p == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            
            IsCart.Remove(p);
            Session["strCart"] = IsCart;
            return View("index", IsCart);
        }





    }
}