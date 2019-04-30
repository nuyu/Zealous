using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

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
            //Collect progress data for current event
            var eventProgress = db.EventTrackings.Where(e => e.EventId == id).ToList();
            var evnt = db.Events.FirstOrDefault(e => e.Id == id);

            //
            var eList = new List<ProgressDetail>();
            foreach (var e in eventProgress)
                eList.Add(new ProgressDetail {
                    Id = e.Id,
                    EventId = e.EventId,
                    CustomerId = e.CustomerId,
                    OrganizerId = e.OrganizerId,
                    SupplierId  = e.SupplierId,
                    Date  = e.Date,
                    Note = e.Note,
                    EventStatus = e.EventStatus,
                    EventName = evnt.EventName
            });
            return View(eList);
        }

        // Track one event progress
        public ActionResult UpdateEventProgress(int id, byte statusId)
        {
            var track = new EventTracking { EventId = id, EventStatus = statusId };
            db.EventTrackings.Add(track);
            db.SaveChanges();
            return View();
        }


    }
}