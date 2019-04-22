using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class ZealousController : Controller
    {
        private ZealousContext _db;
        public ZealousContext db {
            get {
                if (_db == null)
                    _db = new ZealousContext();
                return _db;
            }


        }
        //// GET: Zealous
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}