using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThinkBridge.Models;

namespace ThinkBridge.Controllers
{
    public class TeamMembersController1 : Controller
    {
        private DatabaseContext db = new DatabaseContext();

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
            return View();
        }

        // POST: TeamMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamId,Name,MobileNumber,TeamName,EmailId,BloodGroup")] TeamMembers teamMembers)
        {
            if (ModelState.IsValid)
            {
                db.TeamMembers.Add(teamMembers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamMembers);
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
            return View(teamMembers);
        }

        // POST: TeamMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamId,Name,MobileNumber,TeamName,EmailId,BloodGroup")] TeamMembers teamMembers)
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
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamMembers teamMembers = db.TeamMembers.Find(id);
            db.TeamMembers.Remove(teamMembers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTeam()
        {
            return View();
        }

        public ActionResult AddTeam(TeamDetails teamDetails)
        {
            return View();
        }

        public ActionResult DisplayTeam()
        {
            return View(db.TeamDetails.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
