using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThinkBridge.Models;
using ThinkBridge.Services;

namespace ThinkBridge.Controllers
{
    public class TeamMembersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        ThinkBridge.Services.MembersServices services = new ThinkBridge.Services.MembersServices();
        // GET: TeamMembers
        public ActionResult Index()
        {
            return View(db.TeamMembers.ToList());
        }

        // GET: TeamMembers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMembers teamMembers = db.TeamMembers.Find(id);
            if (teamMembers == null)
            {
                return HttpNotFound();
            }
            return View(teamMembers);
        }

        // GET: TeamMembers/Create
        public ActionResult Create()
        {
            
            ViewBag.check = (from c in db.TeamMembers
                          where (c.EmployeeStatus == "InActive")
                          select c).ToList();
            
            return View();
        }

        // POST: TeamMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Exclude = "EmployeeStatus")] */TeamMembers teamMembers)
            {
            if (ModelState.IsValid)
            {
                teamMembers.EmployeeStatus = "Active";
                try
                {
                    bool UserExist = services.UserExists(teamMembers);
                    if (UserExist)
                    {
                        ModelState.AddModelError("", "User Already Exists");
                        return View(teamMembers);
                    }
                    else
                    {
                        db.TeamMembers.Add(teamMembers);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(teamMembers);
                }
            }
            else
            {
                foreach (ModelState modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        
                    }
                }
            }

            return View(teamMembers);
        }

        public ActionResult TeamCount()
        {

            List<Reports> reports = services.Reports();
            ViewBag.ActiveEmployees = reports.Sum(m => m.ActiveEmployees);
            ViewBag.InActiveEmployees = reports.Sum(m => m.InActiveEmployees);

            return View(reports);
            
        }
        
        public ActionResult DesignationReport()
        {
            List<Designations>designations= services.DesignationCount();
            return PartialView("_DesignationReport",designations);
        }

        // GET: TeamMembers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMembers teamMembers = db.TeamMembers.Find(id);
            if (teamMembers == null)
            {
                return HttpNotFound();
            }
            ViewBag.check = (from c in db.TeamMembers
                             where (c.EmployeeStatus == "InActive")
                             select c).ToList();
            return View(teamMembers);
        }

        // POST: TeamMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamId,EmployeeID,Name,EmployeeStatus,MobileNumber,TeamName,EmailId,BloodGroup,Designation,JoiningDate,PreviousExperience,CTC,EarlierSalary,CurrentExperience,CompanyAssetDetails,SalaryReviewMonth,Education,FatherOrHusbandName,TraineeReviewMonth,JoineeProbationReview,Hike,PFNumber,MedicalInsuaranceByThinkbridge,Gender")]TeamMembers teamMembers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamMembers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamMembers);
        }

        // GET: TeamMembers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamMembers teamMembers = db.TeamMembers.Find(id);
            if (teamMembers == null)
            {
                return HttpNotFound();
            }
            return View(teamMembers);
        }

        // POST: TeamMembers/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                TeamMembers teamMembers = db.TeamMembers.Find(id);
                teamMembers.EmployeeStatus = "InActive";
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
           
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpGet]
        public ActionResult AddTeam()
        {
            List<SelectListItem> ls = new List<SelectListItem>() {
            new SelectListItem() { Text = "Active", Value = "Active" },
            new SelectListItem() { Text = "InActive", Value = "InActive" }
            };
            ViewBag.Status = ls;
            return View();
        }
        [HttpPost]
        public ActionResult AddTeam(TeamDetails teamDetails)
        {
            if (ModelState.IsValid)
            {
                db.TeamDetails.Add(teamDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult DisplayTeam()
        {
            return View(db.TeamDetails.ToList());
        }
        
        //public ActionResult TeamDetails(int id)
        //{
        //    TeamInfo team = new TeamInfo();
        //    team = from check in db.TeamDetails
        //           select  m=> new TeamInfo(
        //               team.ProjectLead = check.ProjectLead,
        //               team.TeamName = check.TeamName,
        //               team.TeamLeader = check.TeamLeader
        //                );

        //    return View();
        //}
    }
}
