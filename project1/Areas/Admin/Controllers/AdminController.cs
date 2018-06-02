using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin,User")]
    public class AdminController:Controller
    {
    }
}