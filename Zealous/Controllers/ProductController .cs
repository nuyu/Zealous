using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zealous.Models;

namespace Zealous.Controllers
{
    public class ProdutController : ZealousController
    {

       //GET: Products
       public ActionResult Index()
        {
            return View();
        }

       public PartialviewResult ProductListPartial()
        {
            var productList = database;
            return PartialView(productList);
        }

    }
}