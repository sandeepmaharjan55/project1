using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Areas.Admin.Controllers
{
    public class SettingsController : AdminController
    {
        // GET: Admin/Settings
        public ActionResult Index()
        {
            return View();
        }
    }
}