using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Registration.Models;

namespace Registration.Controllers
{
    public class selectprofController : Controller
    {
        [HttpPost]
        public JsonResult FillProfessor(string id)
        {

            ApplicationDbContext DB = new ApplicationDbContext();

            int DeptID = int.Parse(id);
          
            DB.Configuration.ProxyCreationEnabled = false;
            List<professor> prof = DB.dbpro.Where(a => a.DeptID == DeptID).ToList();
            return Json(prof, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public ActionResult Save(string ID_Dept, string ProfID)
        {
            //ApplicationDbContext DB = new ApplicationDbContext();
            //SelectedProf prof = new SelectedProf();
            //prof.DeptID = int.Parse(ID_Dept);
            //prof.ProfID = int.Parse(ProfID);
            //DB.SelectedProf.Add(prof);
            //DB.SaveChanges();
            
            return RedirectToAction("success","selectprof");

        }
        public ActionResult success()
        {

            return View("~/Views/Home/success.cshtml");
        }

        public ActionResult DropDown()
        {
            //ApplicationDbContext db=new ApplicationDbContext();
            //var xx = db.Department.ToList();
            return View("~/Views/Home/selectprof.cshtml");
        }
    }
}