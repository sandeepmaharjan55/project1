using project1.Models;
using project1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class RegisterController : Controller
    {
        private MyDbContext db = new MyDbContext();
        [AllowAnonymous]
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RegisterViewModel rvm)
        {
            
                if (db.Users.Count(u => u.Username == rvm.UserName) == 0 && db.Users.Count(u => u.Email == rvm.Email) == 0)
                {
                    User user = new User()
                    {
                        Username = rvm.UserName,
                        Password = rvm.Password,
                        Contact = rvm.Contact,
                        Email = rvm.Email,
                        Gender = rvm.Gender,
                        AddedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Status = true,
                        Name = rvm.Name,
                        Education=rvm.Education,
                        Designation = rvm.Designation

                    };

                db.Users.Add(user);
                    db.SaveChanges();
                    db.UserRoles.Add(new UserRole()
                    {
                        UserId = user.Id,
                        RoleId = 3

                    });
                    db.SaveChanges();


                    return Redirect("~/Admin/Dashboard");
                }
                else
            {
                ViewBag.Error = "Email ALready Exists";
            }
                return View(rvm);
            }
        }
  }