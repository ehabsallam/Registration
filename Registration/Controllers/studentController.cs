using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.viewmodel;
using Registration.Models;

namespace Registration.Controllers
{
    public class studentController : Controller
    {
        
        /// open Database
       
        ApplicationDbContext db = new ApplicationDbContext();
        public static bool test = false;
        public static int check = -1;
        public static int id = -1;
        
        //
        // GET: /student/
        public ActionResult Index()
        {
            var data = db.dbleader.SqlQuery("select * from teamLeaders").ToList();
            return Content(data[0].nameLeader);
        }

        [HttpGet]
        public ActionResult registrationStudent()
        {
            ViewBag.test = test;
            ViewBag.check = check;
            return View();
        }

        [HttpPost]
        public ActionResult registrationStudent(TeamIdea cm)
        {
            
            if (test == false)
            {
                //-------Team Leader---------
                //var checkId= db.dbleader.ToList().Single(n => n.idLeader == cm.leader.idLeader);
                //if (checkId == null)
                //{
                
                    id = cm.leader.idLeader;
                    db.dbleader.Add(cm.leader);
                    db.SaveChanges();
                    check++;
                    test = true;
                    return RedirectToAction("registrationStudent");
                //}
                //else return Content("The Id earldy Exist" + checkId);              
            }
            else if (check >= 0 && check < 3)
            {
                //-------Student--------
                cm.std.frLeader = id;
                db.dbstd.Add(cm.std);
                db.SaveChanges();
                check++;
                return RedirectToAction("registrationStudent");

            }
            else
            {
                cm.std.frLeader = id;
                db.dbstd.Add(cm.std);
                db.SaveChanges();
                return RedirectToAction("registrationIdea");
            }
        }

        [HttpGet]
        public ActionResult registrationIdea()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registrationIdea(TeamIdea cm)
        {
            cm.idea.frLeader = id;
            db.dbidea.Add(cm.idea);
            db.SaveChanges();
            //return View();
           // return RedirectToAction("profile", "professor");
            return RedirectToAction("profile", "professor");
            return Content("Done"); 
        }

	}
}