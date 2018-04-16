using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThinkBridge.Models;

namespace ThinkBridge.Services
{
    public class MembersServices
    {
        public DatabaseContext db = new DatabaseContext();
        public List<Reports> Reports()
        {
            List<Reports> report = new List<Reports>();
            
            foreach (TeamDetails teamDetails in db.TeamDetails)
            {
                Reports reports = new Reports();
                reports.TeamName = teamDetails.TeamName;
                reports.MemberCount = db.TeamMembers.AsNoTracking().Count(m => m.TeamName == reports.TeamName && m.EmployeeStatus=="Active");
                //reports.MemberCount = ((from TeamCount in db.TeamMembers
                //                        select TeamCount.TeamName== reports.TeamName)).Count();
                reports.ActiveEmployees = (from ActiveEmp in db.TeamMembers
                                                where ActiveEmp.EmployeeStatus == "Active" && ActiveEmp.TeamName== reports.TeamName
                                           select ActiveEmp.EmployeeStatus).Count();
                reports.InActiveEmployees = (from ActiveEmp in db.TeamMembers
                                                  where ActiveEmp.EmployeeStatus == "Inactive" && ActiveEmp.TeamName == reports.TeamName
                                             select ActiveEmp.EmployeeStatus).Count();
                //reports.Designation = (from ActiveEmp in db.TeamMembers
                //                       select ActiveEmp.Designation);

                report.Add(reports);
            }
            

            //reports.Designation = (from ActiveEmp in db.TeamMembers
            //                       select ActiveEmp.Designation).Count();
            return report;
        }
        public List<Designations> DesignationCount()
        {
            List<Designations> designations = new List<Designations>();
             var Designation = (from ActiveEmp in db.TeamMembers
                                     select ActiveEmp).ToList();
            foreach(var t in Designation)
            {
                Designations designation = new Designations();
                designation.Designation = t.Designation;
                designation.DesignationCount = t.Designation.Count();
                designations.Add(designation);
            }
            return designations;
        }
        public bool UserExists(TeamMembers team)
        {
            var UserList = (from user in db.TeamMembers
                            where user.EmailId == team.EmailId
                            select user).ToList();
            if (UserList.Count > 0 && UserList != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}