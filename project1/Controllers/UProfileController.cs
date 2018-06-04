using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class UProfileController : Controller
    {
        [Authorize(Roles ="User")]
        // GET: UProfile
        public ActionResult PageProfile()
        {
            return View();
        }
    }
}