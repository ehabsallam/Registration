using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.viewmodel;
using Registration.Models;
using Registration.Controllers;

namespace Registration.Controllers
{
    public class professorController : Controller
    {
        
        ApplicationDbContext db = new ApplicationDbContext();
       
        //
        // GET: /professor/
        public ActionResult Index()
        {
           // string idprof = @Session["id"].ToString();
            //var allIdea = db.dbidea.SqlQuery("select i.* from ideaTeams i INNER JOIN idea_professor c on( c.idea_id_fk = i.id)   where c.professor_id_fk = 2").ToList();
           // return Content(""+@Session["id"]);
           return View(getCustomers().ToList());
        }
        public IEnumerable<ideaTeam> getCustomers()//generk datatype list
        {
            string idprof = @Session["id"].ToString();
            int idprofessor = int.Parse(idprof);
            var allIdea = db.dbidea.SqlQuery("select i.* from ideaTeams i INNER JOIN idea_professor c on( c.idea_id_fk = i.id)   where c.professor_id_fk = '" + idprofessor + "' and c.accept_reject_idea='null'").ToList();

            return allIdea;
        }

        public ActionResult Details(int id)
        {
            
            //--------- idea details and id teamleader----------------
            var ideadetails= db.dbidea.SingleOrDefault(c => c.id == id);
            ////return idea Details
            ViewBag.dataidea = ideadetails;
            ////--------- Team Leader Name --------------
            var teamLeaderName = db.dbleader.SingleOrDefault(m => m.idLeader == ideadetails.frLeader);
            //// Carry all data of team leader 
            ViewBag.leader = teamLeaderName;
            ////--------- student name ---------------------
            var student = db.dbstd.SqlQuery("select * from students where frLeader = "+teamLeaderName.idLeader).ToList();
            ////Carry all student info in list 
            ViewBag.student = student;
            return View();
            }


        // ActionResult btrg3lii view or content
        public ActionResult Accept(int id )
        {
            string idprof = @Session["id"].ToString();
            int idprofessor = int.Parse(idprof);

            var accept = db.dbIdeaPro.Single(m => m.idea_id_fk == id && m.professor_id_fk == idprofessor);
            accept.accept_reject_idea = "true";
            db.SaveChanges();
            return Content("idea Is accepted" + id);
        }
        public ActionResult Reject(int id)
        {
            string idprof = @Session["id"].ToString();
            int idprofessor = int.Parse(idprof);
            var accept = db.dbIdeaPro.Single(m => m.idea_id_fk == id && m.professor_id_fk == idprofessor);
            accept.accept_reject_idea = "False";
            db.SaveChanges();
            return Content("idea Is Rejected" + id);
        }

	}

    

}