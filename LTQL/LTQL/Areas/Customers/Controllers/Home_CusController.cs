using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Areas.Customers.Controllers
{
    public class Home_CusController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        // GET: Customers/Home_Cus
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}