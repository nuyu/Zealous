using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class EventController : ZealousController
    {

        
        [HttpGet]
        [Authorize]

       
        public ActionResult Index()
        {
            var events = db.Events.OrderBy(x => x.EventName).ToList();
            //product.Add(s);


            return View(events);
        }
       
        [HttpPost]
        public ActionResult Index(Event p)
        {
            if (ModelState.IsValid)
            {
                if (Session["cart"] != null)
                {
                    var ls = Session["cart"] as List<Event>;
                    ls.Add(p);
                }
                else
                {
                    Session["cart"] = new List<Event>() { p };
                }
              
                RedirectToAction("Index", "Home"); // Anti F5 submit
            }
            return View(); // model validate is false
        }

     



    }
}