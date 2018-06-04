using project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class UProfileController : Controller
    {

        // GET: UProfile
        [Authorize(Roles = "User")]
        public ActionResult PageProfile(int id)
        {
            User user = new User()
            { };
            
            return View(user.Id);
        }
    }
}