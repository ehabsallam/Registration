using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class LoginController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
       //  GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login (users user)
        {
            var usr = db.User.Where(u => u.user_name == user.user_name && u.user_password == user.user_password).FirstOrDefault();

            if (usr != null)
            {
                Session["id"] = usr.id.ToString();
                Session["user_name"] = usr.user_name.ToString();
                if (usr.user_type == 1)
                {return RedirectToAction("admin");}
                else if (usr.user_type == 2)
                { return RedirectToAction("Index" ,"professor"); }
                else
                {return RedirectToAction("student");}
            }
            else
            {
                ModelState.AddModelError("", "user name or password is wrong");
            }
            return View();
        }

  

           public ActionResult LogeddIn ()
           {
               if( Session["id"] != null) 
               {
                   return View();
               }

               else {
               return RedirectToAction("Login");
               }
           }

    }
}