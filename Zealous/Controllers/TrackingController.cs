using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zealous.Controllers
{
    public class TrackingController : ZealousController
    {
        // GET: Tracking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EventList()
        {
            var events = db.Events.ToList();
            return View(events);
        }

        // Track one event progress
        public ActionResult ProgressDetail(int id)
        {
            return View();
        }

        // Track one event progress
        public ActionResult UpdateEventProgress(int id)
        {
            return View();
        }


    }
}