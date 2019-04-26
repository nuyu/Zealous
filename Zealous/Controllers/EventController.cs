using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Zealous.Models;

namespace Zealous.Controllers
{
    [Authorize]
    public class EventController : ZealousController
    {
        //Return all available events for this user
        public ActionResult EventsList()
        {
            var events = db.Events.ToList();
            return View(events);
        }

        //  GET: Event/Event
        public ActionResult Event()
        {
            return View();
        }

        // Track one event progress
        public ActionResult Track(int id)
        {
            return View();
        }

    }
}
