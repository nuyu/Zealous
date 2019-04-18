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
    public class EventController : Controller
    {
        //Return all available events for this user
        public ActionResult MyEvents()
        {
            return View();
        }

        //  GET: Event/Event
        public ActionResult Event()
        {
            return View();
        }

        // Track one event progress
        public ActionResult Track()
        {
            return View();
        }

    }
}
