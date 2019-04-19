using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class EquipmentController : ZealousController 
    {
        // GET: Equipment
        [HttpGet]
        [Authorize]
        public ActionResult Equip(Equipment e)
        {
            return View();
        }
        

    }
}